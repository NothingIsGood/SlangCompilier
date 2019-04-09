//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SLGrammar.g4 by ANTLR 4.6.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SemanticLanguageGrammar {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SLGrammarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.5")]
[System.CLSCompliant(false)]
public interface ISLGrammarVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>MathExpSum</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathExpSum([NotNull] SLGrammarParser.MathExpSumContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathExpSub</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathExpSub([NotNull] SLGrammarParser.MathExpSubContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathExpEmpty</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathExpEmpty([NotNull] SLGrammarParser.MathExpEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Bigger</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolInequality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBigger([NotNull] SLGrammarParser.BiggerContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Lesser</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolInequality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLesser([NotNull] SLGrammarParser.LesserContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>LesserOrEqual</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolInequality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLesserOrEqual([NotNull] SLGrammarParser.LesserOrEqualContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolInequalityEmpty</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolInequality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolInequalityEmpty([NotNull] SLGrammarParser.BoolInequalityEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BiggerOrEqual</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolInequality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBiggerOrEqual([NotNull] SLGrammarParser.BiggerOrEqualContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>LogicOr</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicOr([NotNull] SLGrammarParser.LogicOrContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolOrEmpty</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolOrEmpty([NotNull] SLGrammarParser.BoolOrEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathFactorUnaryMinus</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathFactorUnaryMinus([NotNull] SLGrammarParser.MathFactorUnaryMinusContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathFactorBrackets</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathFactorBrackets([NotNull] SLGrammarParser.MathFactorBracketsContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathFactorEmpty</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathFactorEmpty([NotNull] SLGrammarParser.MathFactorEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathFactorUnaryPlus</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathFactorUnaryPlus([NotNull] SLGrammarParser.MathFactorUnaryPlusContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolAndEmpty</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolAndEmpty([NotNull] SLGrammarParser.BoolAndEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>LogicAnd</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicAnd([NotNull] SLGrammarParser.LogicAndContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolAtomBrackets</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolAtomBrackets([NotNull] SLGrammarParser.BoolAtomBracketsContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Not</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNot([NotNull] SLGrammarParser.NotContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolAtomEmpty</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolAtomEmpty([NotNull] SLGrammarParser.BoolAtomEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolAtomBracketsNot</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolAtomBracketsNot([NotNull] SLGrammarParser.BoolAtomBracketsNotContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IfElseIfElse</c>
	/// labeled alternative in <see cref="SLGrammarParser.if_cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfElseIfElse([NotNull] SLGrammarParser.IfElseIfElseContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IfSingle</c>
	/// labeled alternative in <see cref="SLGrammarParser.if_cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfSingle([NotNull] SLGrammarParser.IfSingleContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolEqualityEmpty</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolEquality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolEqualityEmpty([NotNull] SLGrammarParser.BoolEqualityEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathNotEqual</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolEquality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathNotEqual([NotNull] SLGrammarParser.MathNotEqualContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolNotEqual</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolEquality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolNotEqual([NotNull] SLGrammarParser.BoolNotEqualContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolEqual</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolEquality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolEqual([NotNull] SLGrammarParser.BoolEqualContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathEqual</c>
	/// labeled alternative in <see cref="SLGrammarParser.boolEquality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathEqual([NotNull] SLGrammarParser.MathEqualContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathTermDiv</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathTermDiv([NotNull] SLGrammarParser.MathTermDivContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathTermMod</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathTermMod([NotNull] SLGrammarParser.MathTermModContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathTermMul</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathTermMul([NotNull] SLGrammarParser.MathTermMulContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MathTermEmpty</c>
	/// labeled alternative in <see cref="SLGrammarParser.mathTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathTermEmpty([NotNull] SLGrammarParser.MathTermEmptyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeName([NotNull] SLGrammarParser.TypeNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.ptrType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPtrType([NotNull] SLGrammarParser.PtrTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.scalarType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScalarType([NotNull] SLGrammarParser.ScalarTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.functionalType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionalType([NotNull] SLGrammarParser.FunctionalTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.simpleType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleType([NotNull] SLGrammarParser.SimpleTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.functionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionType([NotNull] SLGrammarParser.FunctionTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.procedureType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureType([NotNull] SLGrammarParser.ProcedureTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.functionalArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionalArgList([NotNull] SLGrammarParser.FunctionalArgListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.functionalArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionalArg([NotNull] SLGrammarParser.FunctionalArgContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayType([NotNull] SLGrammarParser.ArrayTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.arrayDimention"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayDimention([NotNull] SLGrammarParser.ArrayDimentionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStart([NotNull] SLGrammarParser.StartContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.moduleImportList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleImportList([NotNull] SLGrammarParser.ModuleImportListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.moduleImport"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleImport([NotNull] SLGrammarParser.ModuleImportContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.module"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule([NotNull] SLGrammarParser.ModuleContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.moduleDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleDeclare([NotNull] SLGrammarParser.ModuleDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.base_head"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBase_head([NotNull] SLGrammarParser.Base_headContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.inherit_head"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInherit_head([NotNull] SLGrammarParser.Inherit_headContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.classDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDeclare([NotNull] SLGrammarParser.ClassDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.classStatements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassStatements([NotNull] SLGrammarParser.ClassStatementsContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.methodDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodDeclare([NotNull] SLGrammarParser.MethodDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.thisHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThisHeader([NotNull] SLGrammarParser.ThisHeaderContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.methodFuncAbstract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodFuncAbstract([NotNull] SLGrammarParser.MethodFuncAbstractContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.methodProcAbstract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodProcAbstract([NotNull] SLGrammarParser.MethodProcAbstractContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.methodFuncDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodFuncDeclare([NotNull] SLGrammarParser.MethodFuncDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.methodProcDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodProcDeclare([NotNull] SLGrammarParser.MethodProcDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.fieldDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldDeclare([NotNull] SLGrammarParser.FieldDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.functionDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclare([NotNull] SLGrammarParser.FunctionDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.procedureDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureDeclare([NotNull] SLGrammarParser.ProcedureDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.varModuleDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarModuleDeclare([NotNull] SLGrammarParser.VarModuleDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.functionalDeclareArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionalDeclareArgList([NotNull] SLGrammarParser.FunctionalDeclareArgListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.functionalDeclareArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionalDeclareArg([NotNull] SLGrammarParser.FunctionalDeclareArgContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.moduleEntry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleEntry([NotNull] SLGrammarParser.ModuleEntryContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.statementSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementSeq([NotNull] SLGrammarParser.StatementSeqContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] SLGrammarParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.simpleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleStatement([NotNull] SLGrammarParser.SimpleStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.complexStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComplexStatement([NotNull] SLGrammarParser.ComplexStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.declare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclare([NotNull] SLGrammarParser.DeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.constDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstDeclare([NotNull] SLGrammarParser.ConstDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.varDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDeclare([NotNull] SLGrammarParser.VarDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.scalarDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScalarDeclare([NotNull] SLGrammarParser.ScalarDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.arrayDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayDeclare([NotNull] SLGrammarParser.ArrayDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.ptrDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPtrDeclare([NotNull] SLGrammarParser.PtrDeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.arrayDeclareType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayDeclareType([NotNull] SLGrammarParser.ArrayDeclareTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.arrayDeclareDimention"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayDeclareDimention([NotNull] SLGrammarParser.ArrayDeclareDimentionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.arrayElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayElement([NotNull] SLGrammarParser.ArrayElementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.arrayLenProperty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayLenProperty([NotNull] SLGrammarParser.ArrayLenPropertyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.let"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLet([NotNull] SLGrammarParser.LetContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.simpleLet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleLet([NotNull] SLGrammarParser.SimpleLetContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.arrayLet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayLet([NotNull] SLGrammarParser.ArrayLetContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUsing([NotNull] SLGrammarParser.UsingContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.return_val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturn_val([NotNull] SLGrammarParser.Return_valContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInput([NotNull] SLGrammarParser.InputContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutput([NotNull] SLGrammarParser.OutputContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.outputArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputArgument([NotNull] SLGrammarParser.OutputArgumentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCall([NotNull] SLGrammarParser.CallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.callArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallArgList([NotNull] SLGrammarParser.CallArgListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.callArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallArg([NotNull] SLGrammarParser.CallArgContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.call_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCall_func([NotNull] SLGrammarParser.Call_funcContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.if_cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf_cond([NotNull] SLGrammarParser.If_condContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.while_cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhile_cond([NotNull] SLGrammarParser.While_condContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.repeat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeat([NotNull] SLGrammarParser.RepeatContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.mathExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathExpression([NotNull] SLGrammarParser.MathExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.mathTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathTerm([NotNull] SLGrammarParser.MathTermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.mathFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathFactor([NotNull] SLGrammarParser.MathFactorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolExpression([NotNull] SLGrammarParser.BoolExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.boolAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolAnd([NotNull] SLGrammarParser.BoolAndContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.boolEquality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolEquality([NotNull] SLGrammarParser.BoolEqualityContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.boolInequality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolInequality([NotNull] SLGrammarParser.BoolInequalityContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.boolFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolFactor([NotNull] SLGrammarParser.BoolFactorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.newExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewExp([NotNull] SLGrammarParser.NewExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.ptrExpAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPtrExpAtom([NotNull] SLGrammarParser.PtrExpAtomContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.expAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpAtom([NotNull] SLGrammarParser.ExpAtomContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitId([NotNull] SLGrammarParser.IdContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArray([NotNull] SLGrammarParser.ArrayContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExp([NotNull] SLGrammarParser.ExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.raw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRaw([NotNull] SLGrammarParser.RawContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLGrammarParser.any"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAny([NotNull] SLGrammarParser.AnyContext context);
}
} // namespace SemanticLanguageGrammar
