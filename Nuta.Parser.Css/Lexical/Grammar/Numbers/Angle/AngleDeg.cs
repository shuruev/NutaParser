using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class AngleDeg : ParseAll
	{
		public static readonly AngleDeg S = new AngleDeg();

		public AngleDeg()
			: base(
				Number.S,
				LetterD.S,
				LetterE.S,
				LetterG.S)
		{
		}
	}
}
