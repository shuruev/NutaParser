using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class AsciiDigits : ParseMany
	{
		public static readonly AsciiDigits S = new AsciiDigits();
		public static readonly Optional O = new Optional(S);

		public AsciiDigits()
			: base(AsciiDigit.S)
		{
		}
	}
}
