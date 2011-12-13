using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class BottomLeftCorner : SpecificAtKeyword
	{
		public static readonly BottomLeftCorner S = new BottomLeftCorner();

		public BottomLeftCorner()
			: base(
				AtSignTerminal.S,
				LetterB.S,
				LetterO.S,
				LetterT.S,
				LetterT.S,
				LetterO.S,
				LetterM.S,
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
