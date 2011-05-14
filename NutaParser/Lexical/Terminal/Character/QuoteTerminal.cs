namespace NutaParser.Lexical.Grammar
{
	public class QuoteTerminal : SingleCharacterTerminal
	{
		public static readonly QuoteTerminal S = new QuoteTerminal();

		public QuoteTerminal()
			: base('"')
		{
		}
	}
}
