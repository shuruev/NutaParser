using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class FreqKhz : ParseAll
	{
		public static readonly FreqKhz S = new FreqKhz();

		public FreqKhz()
			: base(
				Number.S,
				LetterK.S,
				LetterH.S,
				LetterZ.S)
		{
		}
	}
}
