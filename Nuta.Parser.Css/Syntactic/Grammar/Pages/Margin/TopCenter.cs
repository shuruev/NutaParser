using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class TopCenter : SpecificAtKeyword
	{
		public static readonly TopCenter S = new TopCenter();

		public TopCenter()
			: base(
				AtSignTerminal.S,
				LetterT.S,
				LetterO.S,
				LetterP.S,
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
