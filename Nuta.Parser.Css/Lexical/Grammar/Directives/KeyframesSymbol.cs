using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class KeyframesSymbol : ParseAll
	{
		public static readonly KeyframesSymbol S = new KeyframesSymbol();

		public KeyframesSymbol()
			: base(
				AtSignTerminal.S,
				LetterK.S,
				LetterE.S,
				LetterY.S,
				LetterF.S,
				LetterR.S,
				LetterA.S,
				LetterM.S,
				LetterE.S,
				LetterS.S)
		{
		}
	}
}
