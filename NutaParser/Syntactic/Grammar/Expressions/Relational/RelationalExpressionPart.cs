namespace NutaParser.Syntactic.Grammar
{
	public class RelationalExpressionPart : ParseAny
	{
		public static readonly RelationalExpressionPart S = new RelationalExpressionPart();

		public RelationalExpressionPart()
			: base(
				new ParseAll(LeftAngleBracketTerminal.S, ShiftExpression.S),
				new ParseAll(RightAngleBracketTerminal.S, ShiftExpression.S),
				new ParseAll(LessOrEqualTerminal.S, ShiftExpression.S),
				new ParseAll(GreaterOrEqualTerminal.S, ShiftExpression.S),
				new ParseAll(IsTerminal.S, Type.S),
				new ParseAll(AsTerminal.S, Type.S))
		{
		}
	}
}
