using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class AngleRad : ParseAll
	{
		public static readonly AngleRad S = new AngleRad();

		public AngleRad()
			: base(
				Number.S,
				LetterR.S,
				LetterA.S,
				LetterD.S)
		{
		}
	}
}
