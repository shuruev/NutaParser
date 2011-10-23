using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class ResolutionDpcm : ParseAll
	{
		public static readonly ResolutionDpcm S = new ResolutionDpcm();

		public ResolutionDpcm()
			: base(
				Number.S,
				LetterD.S,
				LetterP.S,
				LetterC.S,
				LetterM.S)
		{
		}
	}
}
