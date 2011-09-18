using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class LengthCm : ParseAll
	{
		public static readonly LengthCm S = new LengthCm();

		public LengthCm()
			: base(
				Number.S,
				LetterC.S,
				LetterM.S)
		{
		}
	}
}
