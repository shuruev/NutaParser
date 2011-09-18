using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class LengthPt : ParseAll
	{
		public static readonly LengthPt S = new LengthPt();

		public LengthPt()
			: base(
				Number.S,
				LetterP.S,
				LetterT.S)
		{
		}
	}
}
