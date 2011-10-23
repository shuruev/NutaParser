using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class And : ParseAll
	{
		public static readonly And S = new And();

		public And()
			: base(
				LetterA.S,
				LetterN.S,
				LetterD.S)
		{
		}
	}
}
