using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class RightTop : SpecificAtKeyword
	{
		public static readonly RightTop S = new RightTop();

		public RightTop()
			: base(
				AtSignTerminal.S,
				LetterR.S,
				LetterI.S,
				LetterG.S,
				LetterH.S,
				LetterT.S,
				HyphenTerminal.S,
				LetterT.S,
				LetterO.S,
				LetterP.S)
		{
		}
	}
}
