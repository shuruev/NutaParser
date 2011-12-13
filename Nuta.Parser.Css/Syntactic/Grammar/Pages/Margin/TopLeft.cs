using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class TopLeft : SpecificAtKeyword
	{
		public static readonly TopLeft S = new TopLeft();

		public TopLeft()
			: base(
				AtSignTerminal.S,
				LetterT.S,
				LetterO.S,
				LetterP.S,
				HyphenTerminal.S,
				LetterL.S,
				LetterE.S,
				LetterF.S,
				LetterT.S)
		{
		}
	}
}
