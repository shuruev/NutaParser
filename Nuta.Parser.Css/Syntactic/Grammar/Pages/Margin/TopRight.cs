using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class TopRight : SpecificAtKeyword
	{
		public static readonly TopRight S = new TopRight();

		public TopRight()
			: base(
				AtSignTerminal.S,
				LetterT.S,
				LetterO.S,
				LetterP.S,
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
