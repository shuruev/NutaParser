using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class ResolutionDpi : ParseAll
	{
		public static readonly ResolutionDpi S = new ResolutionDpi();

		public ResolutionDpi()
			: base(
				Number.S,
				LetterD.S,
				LetterP.S,
				LetterI.S)
		{
		}
	}
}
