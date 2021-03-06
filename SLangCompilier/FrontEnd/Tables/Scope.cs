﻿using System.Collections.Generic;

namespace SLangCompiler.FrontEnd.Tables
{
    // Base scope class logic
    public class Scope
    {
        public Scope Outer { get; set; }

        public Dictionary<string, VariableNameTableItem> Names { get; set; }

        public Scope(Scope outer)
        {
            Names = new Dictionary<string, VariableNameTableItem>();
            Outer = outer;
        }

        public Scope(Dictionary<string, VariableNameTableItem> names, Scope outer)
        {
            Names = names;
            Outer = outer;
        }

        public Scope()
        {
            Names = new Dictionary<string, VariableNameTableItem>();
        }

        public void PutVariable(VariableNameTableItem item)
        {
            // присвоение без проверок, очень зависит от контекста
            Names.Add(item.Name, item);
        }

        public VariableNameTableItem FindVariable(string name)
        {
            VariableNameTableItem res = null;
            // find in this scope
            if (Names.ContainsKey(name))
            {
                res = Names[name];
            }
            else
            {
                // search in outer scopes
                var outer = Outer;
                while (outer != null)
                {
                    if (outer.Names.ContainsKey(name))
                    {
                        res = outer.Names[name];
                        break;
                    }

                    outer = outer.Outer;
                }
            }
            return res;
        }
    }
}
