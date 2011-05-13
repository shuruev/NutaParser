namespace NutaParser.Lexical.Grammar
{
	public class PpUnaryExpression1 : LexicalItem
	{
		public static readonly PpUnaryExpression1 S = new PpUnaryExpression1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				ExclamationTerminal.S,
				Whitespace.S,
				PpUnaryExpression.S);
		}
	}
}
