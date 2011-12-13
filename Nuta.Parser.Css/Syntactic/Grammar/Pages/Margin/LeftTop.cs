using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class LeftTop : SpecificAtKeyword
	{
		public static readonly LeftTop S = new LeftTop();

		public LeftTop()
			: base(
				AtSignTerminal.S,
				LetterL.S,
				LetterE.S,
				LetterF.S,
				LetterT.S,
				HyphenTerminal.S,
				LetterT.S,
				LetterO.S,
				LetterP.S)
		{
		}
	}
}
