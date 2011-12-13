using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class LeftBottom : SpecificAtKeyword
	{
		public static readonly LeftBottom S = new LeftBottom();

		public LeftBottom()
			: base(
				AtSignTerminal.S,
				LetterL.S,
				LetterE.S,
				LetterF.S,
				LetterT.S,
				HyphenTerminal.S,
				LetterB.S,
				LetterO.S,
				LetterT.S,
				LetterT.S,
				LetterO.S,
				LetterM.S)
		{
		}
	}
}
