﻿using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using SLangCompiler.FileServices;
using SLangCompiler.FrontEnd.Tables;
using SLangCompiler.FrontEnd.Types;
using SLangGrammar;
using System;
using System.Collections.Generic;
using System.Linq;
using static SLangCompiler.Exceptions.CompilerErrors;

namespace SLangCompiler.FrontEnd
{
    public class SlangStoreRoutinesVisitor : SlangBaseVisitor
    {
        private readonly ModuleNameTable moduleItem;
        public SlangStoreRoutinesVisitor(SourceCodeTable table, ModuleData module) : base(table, module)
        {
            moduleItem = table.Modules[module.Name];
        }
        public override object VisitThisHeader([NotNull] SLangGrammarParser.ThisHeaderContext context) => Visit(context.customType());

        /// <summary>
        /// return custom type for pointer and custom types
        /// </summary>
        /// <param name="type">type</param>
        /// <returns>custom type (if exists), else null</returns>
        private SlangCustomType GetUserType(SlangType type)
        {
            SlangCustomType usedType = null;
            if (type is SlangCustomType t)
            {
                usedType = t;
            }
            else if (type is SlangPointerType pt)
            {
                usedType = pt.PtrType;
            }
            return usedType;
        }
        private void CheckLevelAccessForRoutines(RoutineNameTableItem routine, ITerminalNode routineToken, string routineName)
        {
            foreach (var item in routine.Params)
            {
                var typeArg = item.TypeArg.Type;
                if (typeArg is SlangCustomType || typeArg is SlangPointerType)
                {
                    var customType = GetUserType(typeArg);
                    var classItem = Table.Modules[customType.ModuleName].Classes[customType.Name];
                    if (classItem.AccessModifier == AccessModifier.Private)
                    {
                        ThrowLevelAccessibilityForRoutineException(routineToken, ModuleData.File, customType.ToString(), routineName);
                    }
                }
            }
            if (routine.ReturnType != null)
            {
                if (routine.ReturnType is SlangCustomType || routine.ReturnType is SlangPointerType)
                {
                    var type = GetUserType(routine.ReturnType);
                    var classItem = Table.Modules[type.ModuleName].Classes[type.Name];
                    if (classItem.AccessModifier == AccessModifier.Private)
                    {
                        ThrowLevelAccessibilityForRoutineException(routineToken, ModuleData.File, type.ToString(), routineName);
                    }
                }
            }
        }

        private void CheckLevelAccessForMethods(MethodNameTableItem method, ITerminalNode routineToken, SlangCustomType classIdent)
        {
            foreach (var item in method.Params)
            {
                var typeArg = item.TypeArg.Type;
                if (typeArg is SlangCustomType || typeArg is SlangPointerType)
                {
                    var customType = GetUserType(typeArg);
                    var classItem = Table.Modules[customType.ModuleName].Classes[customType.Name];
                    if (classItem.AccessModifier == AccessModifier.Private && !customType.Equals(classIdent))
                    {
                        ThrowLevelAccessibilityForRoutineException(routineToken, ModuleData.File, customType.ToString(), method.Name);
                    }
                }
            }
            if (method.ReturnType != null)
            {
                if (method.ReturnType is SlangCustomType type)
                {
                    var classItem = Table.Modules[type.ModuleName].Classes[type.Name];
                    if (classItem.AccessModifier == AccessModifier.Private)
                    {
                        ThrowLevelAccessibilityForRoutineException(routineToken, ModuleData.File, type.ToString(), method.Name);
                    }
                }
            }
        }

        public override object VisitFunctionDecl([NotNull] SLangGrammarParser.FunctionDeclContext context)
        {
            ValidateContext(context.thisHeader(), context.Id(), context.importHead(), context.AccessModifier(), context.Abstract(), context.Override(), context.routineArgList(), context.typeName(), context.statementSeq());

            return base.VisitFunctionDecl(context);
        }

        private void ValidateContext(SLangGrammarParser.ThisHeaderContext thisHeader, ITerminalNode id, SLangGrammarParser.ImportHeadContext importHead, ITerminalNode accessModifier, ITerminalNode abstractToken, ITerminalNode overrideToken, SLangGrammarParser.RoutineArgListContext routineArgList, SLangGrammarParser.TypeNameContext typeName, SLangGrammarParser.StatementSeqContext statementSeq)
        {
            var isMethod = thisHeader != null;
            var symbol = id.Symbol;

            string nameOfThis = string.Empty;
            if (isMethod)
            {
                nameOfThis = thisHeader.Id().GetText();
                ThrowIfReservedWord(nameOfThis, ModuleData.File, thisHeader.Id().Symbol);
                if (importHead != null)
                {
                    ThrowImportHeaderMethodsException(ModuleData.File, id);
                }
            }
            var name = id.GetText();
            ThrowIfReservedWord(name, ModuleData.File, symbol);
            var args = Visit(routineArgList) as List<RoutineArgNameTableItem>;
            ImportHeader header = null;
            if (importHead != null)
            {
                header = Visit(importHead) as ImportHeader;
            }

            SlangType returnType = typeName != null ? Visit(typeName) as SlangType : null;
            var modifier = GetModifierByName(accessModifier.GetText());

            var isAbstract = abstractToken != null;
            var isOverride = overrideToken != null;

            if (!isMethod && (isAbstract || isOverride))
            {
                ThrowRoutinesAbstractOverrideException(ModuleData.File, abstractToken ?? overrideToken);
            }

            if (header != null && statementSeq.statement().Length != 0)
            {
                ThrowImportHeaderException(ModuleData.File, id);
            }

            if (isMethod)
            {
                if (Visit(thisHeader) is SlangCustomType methodTypeIdent && methodTypeIdent.ModuleName != ModuleData.Name)
                {
                    ThrowModuleFromOtherClassModuleException(id, ModuleData.File);
                }
                if (isAbstract)
                {
                    ThrowIfAbstractMethodPrivate(modifier, ModuleData.File, id);
                }
                if ((args ?? throw new InvalidOperationException(nameof(args))).Any(a => a.Name == nameOfThis))
                {
                    ThrowConfictsThisException(thisHeader.Id(), ModuleData.File);
                }
                var classData = Visit(thisHeader) as SlangCustomType;
                var foundClass = Table.FindClass(classData);

                if (foundClass.Methods.ContainsKey(name))
                {
                    ThrowMethodSignatureExistsException(classData, id, ModuleData.File);
                }

                if (isAbstract && statementSeq.statement().Length != 0)
                {
                    ThrowAbstractEmptyException(id, ModuleData.File);
                }

                var method = new MethodNameTableItem
                {
                    AccessModifier = modifier,
                    Column = symbol.Column,
                    Header = header,
                    IsAbstract = isAbstract,
                    IsOverride = isOverride,
                    Line = symbol.Line,
                    Name = name,
                    NameOfThis = nameOfThis,
                    Params = args,
                    ReturnType = returnType
                };
                if (modifier == AccessModifier.Public)
                {
                    CheckLevelAccessForMethods(method, id, classData);
                }

                foundClass.CheckRoutineConflicts(moduleItem.ModuleData, method);
                foundClass.Methods.Add(method.Name, method);
            }
            else
            {
                if (moduleItem.Routines.ContainsKey(name))
                {
                    ThrowRoutineExistsException(id, ModuleData.File);
                }

                var routine = new RoutineNameTableItem
                {
                    AccessModifier = modifier,
                    Column = symbol.Column,
                    Line = symbol.Line,
                    Header = header,
                    Name = name,
                    Params = args,
                    ReturnType = returnType
                };

                if (modifier == AccessModifier.Public)
                {
                    CheckLevelAccessForRoutines(routine, id, name);
                }

                moduleItem.CheckCommonNamesConflicts(routine.Name, routine.Line, routine.Column);
                moduleItem.Routines.Add(routine.Name, routine);
            }
        }

        public override object VisitRoutineArgList([NotNull] SLangGrammarParser.RoutineArgListContext context)
        {
            IList<RoutineArgNameTableItem> res = new List<RoutineArgNameTableItem>(context.routineArg().Length);

            foreach (var arg in context.routineArg())
            {
                var routineArg = (RoutineArgNameTableItem)Visit(arg);
                ThrowIfReservedWord(routineArg.Name, ModuleData.File, arg.Id().Symbol);
                if (res.Any(a => a.Name == routineArg.Name))
                {
                    ThrowParameterAlreadyDefinedException(routineArg.Name, ModuleData.File, arg.Id().Symbol);
                }
                res.Add(routineArg);
            }

            return res;
        }

        public override object VisitRoutineArg([NotNull] SLangGrammarParser.RoutineArgContext context)
        {
            var id = context.Id();
            return new RoutineArgNameTableItem
            {
                Column = id.Symbol.Column,
                Line = id.Symbol.Line,
                Name = id.GetText(),
                TypeArg = new SlangRoutineTypeArg(GetParamModifierByName(context.FunctionArgModifier().GetText()), Visit(context.typeName()) as SlangType)
            };
        }

        // same as functions only without return type (maybe i can optimize that later)
        public override object VisitProcedureDecl([NotNull] SLangGrammarParser.ProcedureDeclContext context)
        {
            ValidateContext(context.thisHeader(), context.Id(), context.importHead(), context.AccessModifier(), context.Abstract(), context.Override(), context.routineArgList(), null, context.statementSeq());

            return base.VisitProcedureDecl(context);
        }

        public override object VisitCustomType([NotNull] SLangGrammarParser.CustomTypeContext context)
        {
            if (base.VisitCustomType(context) is SlangCustomType classItem)
            {
                CheckClassExists(classItem.ModuleName, classItem.Name, context.qualident().Id().First().Symbol);
                return classItem;
            }

            return null;
        }
    }
}
