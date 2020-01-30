//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SLangGrammar.g4 by ANTLR 4.6.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SLangGrammar {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SLangGrammarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.5")]
[System.CLSCompliant(false)]
public interface ISLangGrammarVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStart([NotNull] SLangGrammarParser.StartContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.moduleImport"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleImport([NotNull] SLangGrammarParser.ModuleImportContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.module"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule([NotNull] SLangGrammarParser.ModuleContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.moduleStatementsSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleStatementsSeq([NotNull] SLangGrammarParser.ModuleStatementsSeqContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.moduleDeclareSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleDeclareSeq([NotNull] SLangGrammarParser.ModuleDeclareSeqContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.declare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclare([NotNull] SLangGrammarParser.DeclareContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.variableDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDecl([NotNull] SLangGrammarParser.VariableDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.simpleDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleDecl([NotNull] SLangGrammarParser.SimpleDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.arrayDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayDecl([NotNull] SLangGrammarParser.ArrayDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.arrayDeclType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayDeclType([NotNull] SLangGrammarParser.ArrayDeclTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.ptrDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPtrDecl([NotNull] SLangGrammarParser.PtrDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.constDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstDecl([NotNull] SLangGrammarParser.ConstDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.moduleFieldDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModuleFieldDecl([NotNull] SLangGrammarParser.ModuleFieldDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeName([NotNull] SLangGrammarParser.TypeNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.ptrType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPtrType([NotNull] SLangGrammarParser.PtrTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.customType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCustomType([NotNull] SLangGrammarParser.CustomTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.scalarType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScalarType([NotNull] SLangGrammarParser.ScalarTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.simpleType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleType([NotNull] SLangGrammarParser.SimpleTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayType([NotNull] SLangGrammarParser.ArrayTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.arrayDimention"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayDimention([NotNull] SLangGrammarParser.ArrayDimentionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.typeDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeDecl([NotNull] SLangGrammarParser.TypeDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.typeInherit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeInherit([NotNull] SLangGrammarParser.TypeInheritContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.typeFieldDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeFieldDecl([NotNull] SLangGrammarParser.TypeFieldDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.functionDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDecl([NotNull] SLangGrammarParser.FunctionDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.thisHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThisHeader([NotNull] SLangGrammarParser.ThisHeaderContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.routineArgList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRoutineArgList([NotNull] SLangGrammarParser.RoutineArgListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.routineArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRoutineArg([NotNull] SLangGrammarParser.RoutineArgContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.procedureDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureDecl([NotNull] SLangGrammarParser.ProcedureDeclContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.importHead"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportHead([NotNull] SLangGrammarParser.ImportHeadContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.statementSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementSeq([NotNull] SLangGrammarParser.StatementSeqContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] SLangGrammarParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.simpleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleStatement([NotNull] SLangGrammarParser.SimpleStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.complexStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComplexStatement([NotNull] SLangGrammarParser.ComplexStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.let"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLet([NotNull] SLangGrammarParser.LetContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.ifC"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfC([NotNull] SLangGrammarParser.IfCContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.whileC"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileC([NotNull] SLangGrammarParser.WhileCContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.repeatC"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatC([NotNull] SLangGrammarParser.RepeatCContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInput([NotNull] SLangGrammarParser.InputContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutput([NotNull] SLangGrammarParser.OutputContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.returnC"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnC([NotNull] SLangGrammarParser.ReturnCContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCall([NotNull] SLangGrammarParser.CallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.exprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprList([NotNull] SLangGrammarParser.ExprListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExp([NotNull] SLangGrammarParser.ExpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleExpr([NotNull] SLangGrammarParser.SimpleExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] SLangGrammarParser.TermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.signedFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSignedFactor([NotNull] SLangGrammarParser.SignedFactorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactor([NotNull] SLangGrammarParser.FactorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.newC"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewC([NotNull] SLangGrammarParser.NewCContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.designator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignator([NotNull] SLangGrammarParser.DesignatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.designatorStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDesignatorStatement([NotNull] SLangGrammarParser.DesignatorStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SLangGrammarParser.qualident"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQualident([NotNull] SLangGrammarParser.QualidentContext context);
}
} // namespace SLangGrammar
