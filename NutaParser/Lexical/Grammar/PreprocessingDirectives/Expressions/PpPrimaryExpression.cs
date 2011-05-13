namespace NutaParser.Lexical.Grammar
{
	public class PpPrimaryExpression : LexicalItem
	{
		public static readonly PpPrimaryExpression S = new PpPrimaryExpression();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				// TODO: PpPrimaryExpression1.S,
				// TODO: PpPrimaryExpression2.S,
				// TODO: PpPrimaryExpression3.S,
				// TODO: PpPrimaryExpression4.S,
				ConditionalSymbol.S,
				TrueTerminal.S,
				FalseTerminal.S);
		}
	}
}
