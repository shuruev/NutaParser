using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class BottomRightCorner : SpecificAtKeyword
	{
		public static readonly BottomRightCorner S = new BottomRightCorner();

		public BottomRightCorner()
			: base(
				AtSignTerminal.S,
				LetterB.S,
				LetterO.S,
				LetterT.S,
				LetterT.S,
				LetterO.S,
				LetterM.S,
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
