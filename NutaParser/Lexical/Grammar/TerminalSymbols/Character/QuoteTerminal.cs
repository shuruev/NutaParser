namespace NutaParser.Lexical.Grammar
{
	public class QuoteTerminal : LexicalItem
	{
		public static readonly QuoteTerminal S = new QuoteTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, '"');
		}
	}
}
