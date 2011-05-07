namespace NutaParser.Lexical.Grammar
{
	public class QuoteEscapeSequence : LexicalItem
	{
		public static readonly QuoteEscapeSequence S = new QuoteEscapeSequence();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "\"\"");
		}
	}
}
