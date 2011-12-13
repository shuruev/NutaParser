using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class BottomLeft : SpecificAtKeyword
	{
		public static readonly BottomLeft S = new BottomLeft();

		public BottomLeft()
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
				LetterT.S)
		{
		}
	}
}
