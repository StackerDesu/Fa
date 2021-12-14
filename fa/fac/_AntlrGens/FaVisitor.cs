//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Fa.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="FaParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IFaVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.shiftLAssign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiftLAssign([NotNull] FaParser.ShiftLAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.shiftRAssign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiftRAssign([NotNull] FaParser.ShiftRAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.allAssign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAllAssign([NotNull] FaParser.AllAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.shiftLOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiftLOp([NotNull] FaParser.ShiftLOpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.shiftROp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiftROp([NotNull] FaParser.ShiftROpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.ltOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLtOp([NotNull] FaParser.LtOpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.ltEqualOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLtEqualOp([NotNull] FaParser.LtEqualOpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.gtOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGtOp([NotNull] FaParser.GtOpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.gtEqualOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGtEqualOp([NotNull] FaParser.GtEqualOpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.equalOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqualOp([NotNull] FaParser.EqualOpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.notEqualOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotEqualOp([NotNull] FaParser.NotEqualOpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.exprFuncDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprFuncDef([NotNull] FaParser.ExprFuncDefContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.selfOp2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelfOp2([NotNull] FaParser.SelfOp2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.compareOp2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareOp2([NotNull] FaParser.CompareOp2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.changeOp2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChangeOp2([NotNull] FaParser.ChangeOp2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.allOp2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAllOp2([NotNull] FaParser.AllOp2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.intNum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntNum([NotNull] FaParser.IntNumContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.floatNum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloatNum([NotNull] FaParser.FloatNumContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] FaParser.LiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitId([NotNull] FaParser.IdContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.ids"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIds([NotNull] FaParser.IdsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.typeAfter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeAfter([NotNull] FaParser.TypeAfterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.typeSingle"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeSingle([NotNull] FaParser.TypeSingleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.typeMulti"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeMulti([NotNull] FaParser.TypeMultiContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] FaParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.typeVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeVar([NotNull] FaParser.TypeVarContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.typeVarList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeVarList([NotNull] FaParser.TypeVarListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.typeVar2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeVar2([NotNull] FaParser.TypeVar2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.typeVar2List"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeVar2List([NotNull] FaParser.TypeVar2ListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.quotStmtPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuotStmtPart([NotNull] FaParser.QuotStmtPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.quotStmtExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuotStmtExpr([NotNull] FaParser.QuotStmtExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.ifStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStmt([NotNull] FaParser.IfStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.ifExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfExpr([NotNull] FaParser.IfExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.whileStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStmt([NotNull] FaParser.WhileStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.whileStmt2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStmt2([NotNull] FaParser.WhileStmt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.forStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStmt([NotNull] FaParser.ForStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.forStmt2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStmt2([NotNull] FaParser.ForStmt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchStmtPart2Last"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchStmtPart2Last([NotNull] FaParser.SwitchStmtPart2LastContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.quotStmtExprWrap"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuotStmtExprWrap([NotNull] FaParser.QuotStmtExprWrapContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchExprPartLast"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchExprPartLast([NotNull] FaParser.SwitchExprPartLastContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchStmtPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchStmtPart([NotNull] FaParser.SwitchStmtPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchStmt([NotNull] FaParser.SwitchStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchStmtPart2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchStmtPart2([NotNull] FaParser.SwitchStmtPart2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchStmt2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchStmt2([NotNull] FaParser.SwitchStmt2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchExprPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchExprPart([NotNull] FaParser.SwitchExprPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchExpr([NotNull] FaParser.SwitchExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchExprPart2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchExprPart2([NotNull] FaParser.SwitchExprPart2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.switchExpr2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchExpr2([NotNull] FaParser.SwitchExpr2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.quotExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuotExpr([NotNull] FaParser.QuotExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.exprOpt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOpt([NotNull] FaParser.ExprOptContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.newExprItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewExprItem([NotNull] FaParser.NewExprItemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.newExpr1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewExpr1([NotNull] FaParser.NewExpr1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.newExpr2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewExpr2([NotNull] FaParser.NewExpr2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.arrayExpr1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayExpr1([NotNull] FaParser.ArrayExpr1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.arrayExpr2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayExpr2([NotNull] FaParser.ArrayExpr2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.lambdaExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLambdaExpr([NotNull] FaParser.LambdaExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.strongExprBase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStrongExprBase([NotNull] FaParser.StrongExprBaseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.strongExprPrefix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStrongExprPrefix([NotNull] FaParser.StrongExprPrefixContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.strongExprSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStrongExprSuffix([NotNull] FaParser.StrongExprSuffixContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.strongExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStrongExpr([NotNull] FaParser.StrongExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.middleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMiddleExpr([NotNull] FaParser.MiddleExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] FaParser.ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.tmpAssignExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTmpAssignExpr([NotNull] FaParser.TmpAssignExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.idAssignExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdAssignExpr([NotNull] FaParser.IdAssignExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.defVarStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefVarStmt([NotNull] FaParser.DefVarStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.normalStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNormalStmt([NotNull] FaParser.NormalStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmt([NotNull] FaParser.StmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.publicLevel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPublicLevel([NotNull] FaParser.PublicLevelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classTemplates"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassTemplates([NotNull] FaParser.ClassTemplatesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classParent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassParent([NotNull] FaParser.ClassParentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.enumStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumStmt([NotNull] FaParser.EnumStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassStmt([NotNull] FaParser.ClassStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classVarExtFunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassVarExtFunc([NotNull] FaParser.ClassVarExtFuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classVarExt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassVarExt([NotNull] FaParser.ClassVarExtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassVar([NotNull] FaParser.ClassVarContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classFuncName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassFuncName([NotNull] FaParser.ClassFuncNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classFuncBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassFuncBody([NotNull] FaParser.ClassFuncBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classFunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassFunc([NotNull] FaParser.ClassFuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.classEnumItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassEnumItem([NotNull] FaParser.ClassEnumItemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.useStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUseStmt([NotNull] FaParser.UseStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.callConvention"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallConvention([NotNull] FaParser.CallConventionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.importStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportStmt([NotNull] FaParser.ImportStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.libStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLibStmt([NotNull] FaParser.LibStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.namespaceStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceStmt([NotNull] FaParser.NamespaceStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="FaParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] FaParser.ProgramContext context);
}
