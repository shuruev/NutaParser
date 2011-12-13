using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class TopRightCorner : SpecificAtKeyword
	{
		public static readonly TopRightCorner S = new TopRightCorner();

		public TopRightCorner()
			: base(
				AtSignTerminal.S,
				LetterT.S,
				LetterO.S,
				LetterP.S,
				HyphenTerminal.S,
				LetterR.S,
				LetterI.S,
				LetterG.S,
				LetterH.S,
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
