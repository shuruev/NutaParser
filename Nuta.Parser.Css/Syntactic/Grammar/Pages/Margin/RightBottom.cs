using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class RightBottom : SpecificAtKeyword
	{
		public static readonly RightBottom S = new RightBottom();

		public RightBottom()
			: base(
				AtSignTerminal.S,
				LetterR.S,
				LetterI.S,
				LetterG.S,
				LetterH.S,
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
