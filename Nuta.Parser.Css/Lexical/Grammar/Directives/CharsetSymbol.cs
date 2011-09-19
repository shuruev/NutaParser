using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class CharsetSymbol : ParseAll
	{
		public static readonly CharsetSymbol S = new CharsetSymbol();

		public CharsetSymbol()
			: base(
				AtSignTerminal.S,
				LetterC.S,
				LetterH.S,
				LetterA.S,
				LetterR.S,
				LetterS.S,
				LetterE.S,
				LetterT.S)
		{
		}
	}
}
