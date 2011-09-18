using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class LengthPc : ParseAll
	{
		public static readonly LengthPc S = new LengthPc();

		public LengthPc()
			: base(
				Number.S,
				LetterP.S,
				LetterC.S)
		{
		}
	}
}
