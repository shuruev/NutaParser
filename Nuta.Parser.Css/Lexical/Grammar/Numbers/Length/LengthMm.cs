using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class LengthMm : ParseAll
	{
		public static readonly LengthMm S = new LengthMm();

		public LengthMm()
			: base(
				Number.S,
				LetterM.S,
				LetterM.S)
		{
		}
	}
}
