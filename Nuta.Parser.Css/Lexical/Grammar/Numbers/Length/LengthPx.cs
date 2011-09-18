using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class LengthPx : ParseAll
	{
		public static readonly LengthPx S = new LengthPx();

		public LengthPx()
			: base(
				Number.S,
				LetterP.S,
				LetterX.S)
		{
		}
	}
}
