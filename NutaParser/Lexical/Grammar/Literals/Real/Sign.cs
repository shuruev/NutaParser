namespace NutaParser.Lexical.Grammar
{
	public class Sign : LexicalItem
	{
		public static readonly Sign S = new Sign();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => c == '+' || c == '-');
		}
	}
}
