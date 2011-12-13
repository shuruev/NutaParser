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
				IdentifierTerminal.O,
				PseudoPage.O,
				Whitespaces.O,
				LeftCurlyBracketTerminal.S,
				new ParseMany(
					DeclarationList.S,
					Margin.S),
				RightCurlyBracketTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
