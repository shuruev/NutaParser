namespace NutaParser.Lexical.Grammar
{
	public class VerbatimStringLiteral : ParseAll
	{
		public static readonly VerbatimStringLiteral S = new VerbatimStringLiteral();

		public VerbatimStringLiteral()
			: base(
				AtSignTerminal.S,
				QuoteTerminal.S,
				VerbatimStringLiteralCharacters.O,
				QuoteTerminal.S)
		{
		}
	}
}
