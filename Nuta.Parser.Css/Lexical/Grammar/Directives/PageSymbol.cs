using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class PageSymbol : ParseAll
	{
		public static readonly PageSymbol S = new PageSymbol();

		public PageSymbol()
			: base(
				AtSignTerminal.S,
				LetterP.S,
				LetterA.S,
				LetterG.S,
				LetterE.S)
		{
		}
	}
}
