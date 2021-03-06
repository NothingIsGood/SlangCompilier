﻿using Antlr4.Runtime.Misc;
using SLangCompiler.FrontEnd.Types;
using SLangGrammar;

namespace SLangCompiler.BackEnd.Translator
{
    public partial class CppTranslator : SLangGrammarBaseVisitor<object>
    {
        // types logic
        public override object VisitSimpleType([NotNull] SLangGrammarParser.SimpleTypeContext context)
        {
            return new SlangSimpleType(context.SimpleType().GetText());
        }

        public override object VisitArrayType([NotNull] SLangGrammarParser.ArrayTypeContext context)
        {
            var dimension = context.arrayDimention().Length;
            var type = Visit(context.scalarType()) as SlangType;

            return new SlangArrayType(type, dimension);
        }

        public override object VisitArrayDeclType([NotNull] SLangGrammarParser.ArrayDeclTypeContext context)
        {
            var dimension = context.exp().Length;
            var type = Visit(context.scalarType()) as SlangType;

            return new SlangArrayType(type, dimension);
        }

        public override object VisitPtrType([NotNull] SLangGrammarParser.PtrTypeContext context)
        {
            SlangCustomType customType;
            customType = context.customType() != null ? GetCustomTypeContext(context.customType()) : SlangCustomType.Object;
            return new SlangPointerType(customType);
        }

        public override object VisitCustomType([NotNull] SLangGrammarParser.CustomTypeContext context)
        {
            var res = GetCustomTypeContext(context);
            return res;
        }
    }
}
