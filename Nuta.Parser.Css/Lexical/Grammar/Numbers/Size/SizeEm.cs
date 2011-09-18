using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class SizeEm : ParseAll
	{
		public static readonly SizeEm S = new SizeEm();

		public SizeEm()
			: base(
				Number.S,
				LetterE.S,
				LetterM.S)
		{
		}
	}
}
