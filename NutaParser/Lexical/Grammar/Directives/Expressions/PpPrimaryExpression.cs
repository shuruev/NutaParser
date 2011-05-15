namespace NutaParser.Lexical.Grammar
{
	public class PpPrimaryExpression : LexicalItem
	{
		public static readonly PpPrimaryExpression S = new PpPrimaryExpression();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				new ParseAll(
					LeftRoundBracket.S,
					Whitespace.O,
					PpExpression.S,
					Whitespace.O,
					RightRoundBracket.S),
				ConditionalSymbol.S,
				TrueTerminal.S,
				FalseTerminal.S);
		}
	}
}
