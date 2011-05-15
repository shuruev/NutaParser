namespace NutaParser.Lexical.Grammar
{
	public class RegularStringLiteral : ParseAll
	{
		public static readonly RegularStringLiteral S = new RegularStringLiteral();

		public RegularStringLiteral()
			: base(
				QuoteTerminal.S,
				RegularStringLiteralCharacters.O,
				QuoteTerminal.S)
		{
		}
	}
}
