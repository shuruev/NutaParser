using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class RightMiddle : SpecificAtKeyword
	{
		public static readonly RightMiddle S = new RightMiddle();

		public RightMiddle()
			: base(
				AtSignTerminal.S,
				LetterR.S,
				LetterI.S,
				LetterG.S,
				LetterH.S,
				LetterT.S,
				HyphenTerminal.S,
				LetterM.S,
				LetterI.S,
				LetterD.S,
				LetterD.S,
				LetterL.S,
				LetterE.S)
		{
		}
	}
}
