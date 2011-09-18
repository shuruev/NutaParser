using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class AngleGrad : ParseAll
	{
		public static readonly AngleGrad S = new AngleGrad();

		public AngleGrad()
			: base(
				Number.S,
				LetterG.S,
				LetterR.S,
				LetterA.S,
				LetterD.S)
		{
		}
	}
}
