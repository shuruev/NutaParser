using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Page : ParseAll
	{
		public static readonly Page S = new Page();

		public Page()
			: base(
				new LexicalTerminal(PageSymbol.S),
				Whitespaces.O,
				PseudoPage.O,
				LeftCurlyBracketTerminal.S,
				new ParseMany(
					new ParseAll(
						Whitespaces.O,
						Declaration.O),
					SemicolonTerminal.S),
				RightCurlyBracketTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
