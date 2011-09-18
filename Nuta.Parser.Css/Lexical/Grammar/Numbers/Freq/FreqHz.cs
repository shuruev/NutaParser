using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class FreqHz : ParseAll
	{
		public static readonly FreqHz S = new FreqHz();

		public FreqHz()
			: base(
				Number.S,
				LetterH.S,
				LetterZ.S)
		{
		}
	}
}
