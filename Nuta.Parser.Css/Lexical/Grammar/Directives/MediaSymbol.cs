using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class MediaSymbol : ParseAll
	{
		public static readonly MediaSymbol S = new MediaSymbol();

		public MediaSymbol()
			: base(
				AtSignTerminal.S,
				LetterM.S,
				LetterE.S,
				LetterD.S,
				LetterI.S,
				LetterA.S)
		{
		}
	}
}
