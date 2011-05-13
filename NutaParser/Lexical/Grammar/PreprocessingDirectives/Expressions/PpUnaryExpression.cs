namespace NutaParser.Lexical.Grammar
{
	public class PpUnaryExpression : LexicalItem
	{
		public static readonly PpUnaryExpression S = new PpUnaryExpression();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpUnaryExpression1.S,
				PpUnaryExpression2.S,
				PpPrimaryExpression.S);
		}
	}
}
