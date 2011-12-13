using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class LeftMiddle : SpecificAtKeyword
	{
		public static readonly LeftMiddle S = new LeftMiddle();

		public LeftMiddle()
			: base(
				AtSignTerminal.S,
				LetterL.S,
				LetterE.S,
				LetterF.S,
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
