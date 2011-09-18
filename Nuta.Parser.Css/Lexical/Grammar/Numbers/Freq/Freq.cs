using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Freq : ParseAny
	{
		public static readonly Freq S = new Freq();

		public Freq()
			: base(
				FreqHz.S,
				FreqKhz.S)
		{
		}
	}
}
