using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class TopLeftCorner : SpecificAtKeyword
	{
		public static readonly TopLeftCorner S = new TopLeftCorner();

		public TopLeftCorner()
			: base(
				AtSignTerminal.S,
				LetterT.S,
				LetterO.S,
				LetterP.S,
				HyphenTerminal.S,
				LetterL.S,
				LetterE.S,
				LetterF.S,
				LetterT.S,
				HyphenTerminal.S,
				LetterC.S,
				LetterO.S,
				LetterR.S,
				LetterN.S,
				LetterE.S,
				LetterR.S)
		{
		}
	}
}
