using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class FontFaceSymbol : ParseAll
	{
		public static readonly FontFaceSymbol S = new FontFaceSymbol();

		public FontFaceSymbol()
			: base(
				AtSignTerminal.S,
				LetterF.S,
				LetterO.S,
				LetterN.S,
				LetterT.S,
				HyphenTerminal.S,
				LetterF.S,
				LetterA.S,
				LetterC.S,
				LetterE.S)
		{
		}
	}
}
