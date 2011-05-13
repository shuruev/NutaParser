namespace NutaParser.Lexical.Grammar
{
	public class PpUnaryExpression2 : LexicalItem
	{
		public static readonly PpUnaryExpression2 S = new PpUnaryExpression2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				ExclamationTerminal.S,
				PpUnaryExpression.S);
		}
	}
}
