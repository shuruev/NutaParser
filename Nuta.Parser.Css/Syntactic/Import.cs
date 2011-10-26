using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Import : ParseAll
	{
		public static readonly Import S = new Import();

		public Import()
			: base(
				new LexicalTerminal(ImportSymbol.S),
				WhitespaceTerminal.O,
				new ParseAny(
					new LexicalTerminal(StringLiteral.S),
					new LexicalTerminal(UriLiteral.S)),
				WhitespaceTerminal.O,
				MediaQueryList.O,
				SemicolonTerminal.S,
				WhitespaceTerminal.O)
		{
		}
	}
}
