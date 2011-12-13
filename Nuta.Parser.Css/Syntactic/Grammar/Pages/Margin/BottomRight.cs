using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class BottomRight : SpecificAtKeyword
	{
		public static readonly BottomRight S = new BottomRight();

		public BottomRight()
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
				LetterT.S)
		{
		}
	}
}
