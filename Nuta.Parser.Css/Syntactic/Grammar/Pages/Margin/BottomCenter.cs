using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class BottomCenter : SpecificAtKeyword
	{
		public static readonly BottomCenter S = new BottomCenter();

		public BottomCenter()
			: base(
				AtSignTerminal.S,
				LetterB.S,
				LetterO.S,
				LetterT.S,
				LetterT.S,
				LetterO.S,
				LetterM.S,
				HyphenTerminal.S,
				LetterC.S,
				LetterE.S,
				LetterN.S,
				LetterT.S,
				LetterE.S,
				LetterR.S)
		{
		}
	}
}
