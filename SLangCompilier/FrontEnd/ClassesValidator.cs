﻿using SLangCompiler.Exceptions;
using SLangCompiler.FrontEnd.Tables;
using SLangCompiler.FrontEnd.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SLangCompiler.FrontEnd
{
    /// <summary>
    /// Проход по классу с целью проверки:
    /// 1) Переопределений методов
    /// 2) Переопределений полей
    /// 3) Обработка ООП-ошибок
    /// </summary>
    public class ClassesValidator
    {
        private SourceCodeTable Table { get; set; }
        private readonly List<ClassNameTableItem> allClasses = new List<ClassNameTableItem>();
        public ClassesValidator(SourceCodeTable table)
        {
            Table = table;
            foreach (var key in table.Modules.Keys)
            {
                allClasses.AddRange(table.Modules[key].Classes.Values);
            }
        }

        private FileInfo GetFileOfClass(SlangCustomType typeId)
        {
            return Table.Modules[typeId.ModuleName].ModuleData.File;
        }

        /// <summary>
        /// Base checks for base and derived classes
        /// 1) Check abstract and override methods
        /// 2) Checks fields overriding
        /// 3) Add notes about methods from base classes
        /// </summary>
        /// <param name="baseClass">Item for base class</param>
        /// <param name="derivedClass">Item for derived class</param>
        private void CheckClass(ClassNameTableItem baseClass, ClassNameTableItem derivedClass)
        {
            // check fields
            foreach (var item in baseClass.Fields)
            {
                if (item.Value.AccessModifier == AccessModifier.Public)
                {
                    if (derivedClass.Fields.ContainsKey(item.Key))
                    {
                        var field = derivedClass.Fields[item.Key];
                        throw new CompilerException($"Trying to override field {item.Key} from base class {baseClass.TypeIdent} in derived class {derivedClass.TypeIdent}", GetFileOfClass(derivedClass.TypeIdent), field.Line, field.Column);
                    }
                    var cloneField = item.Value.Clone() as FieldNameTableItem;
                    cloneField.IsDerived = true;
                    derivedClass.Fields.Add(item.Key, cloneField);
                }
            }
            // check methods
            // method marked override but does not override
            foreach (var item in derivedClass.Methods)
            {
                if (item.IsOverride)
                {
                    if (!baseClass.Methods.Any(i => i.Name == item.Name && i.Params.SequenceEqual(item.Params)))
                    {
                        throw new CompilerException($"Method {item.Name} marked override but does not override", GetFileOfClass(derivedClass.TypeIdent), item.Line, item.Column);
                    }
                }
            }

            foreach (var item in baseClass.Methods)
            {
                // для каждого метода из базового класса проверяем, есть ли перегрузка
                // если есть -- то базовый метод нет смысла добавлять
                if (!derivedClass.Methods.Any(i => i.Name == item.Name && i.Params.SequenceEqual(item.Params)))
                {
                    var copy = item.Clone() as MethodNameTableItem;
                    copy.IsDerived = true;
                }
            }
        }

        public void Check()
        {
            var dictID = new Dictionary<SlangCustomType, int>();
            var visited = new bool[allClasses.Count()];
            var listAdj = new List<List<int>>();

            for (int i = 0; i < allClasses.Count(); ++i)
            {
                listAdj.Add(new List<int>());
                dictID[allClasses[i].TypeIdent] = i;
            }

            for (int i = 0; i < allClasses.Count(); ++i)
            {
                if (!allClasses[i].TypeIdent.Equals(SlangCustomType.Object))
                {
                    int classId = dictID[allClasses[i].TypeIdent];
                    int baseClassId = dictID[allClasses[i].Base];

                    //listAdj[classId].Add(baseClassId);
                    listAdj[baseClassId].Add(classId);
                }
            }

            var stack = new Stack<int>();
            stack.Push(allClasses.FindIndex(i => i.TypeIdent.Equals(SlangCustomType.Object)));
            while (stack.Count() != 0)
            {
                var index = stack.Pop();
                if (visited[index])
                {
                    var foundClass = allClasses[index];
                    throw new CompilerException($"Class {foundClass.TypeIdent} is in inheritance cycle", GetFileOfClass(foundClass.TypeIdent), foundClass.Line, foundClass.Column);
                }
                else
                {
                    visited[index] = true;
                }

                foreach (var derived in listAdj[index])
                {
                    CheckClass(allClasses[index], allClasses[derived]);
                    stack.Push(derived);
                }
            }
        }
    }
}
