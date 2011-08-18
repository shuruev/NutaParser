namespace NutaParser.Syntactic.Grammar
{
	public class ElementInitializer : ParseAny
	{
		public static readonly ElementInitializer S = new ElementInitializer();

		public ElementInitializer()
			: base(
				NonAssignmentExpression.S,
				new ParseAll(LeftCurlyBracketTerminal.S, ExpressionList.S, RightCurlyBracketTerminal.S))
		{
		}
	}
}
