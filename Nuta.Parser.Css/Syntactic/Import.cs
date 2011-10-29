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
				Whitespaces.O,
				new ParseAny(
					new LexicalTerminal(StringLiteral.S),
					new LexicalTerminal(UriLiteral.S)),
				Whitespaces.O,
				MediaQueryList.O,
				SemicolonTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
