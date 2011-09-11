using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
