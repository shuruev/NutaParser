using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class ZeroDigit : SingleCharacterTerminal
	{
		public static readonly ZeroDigit S = new ZeroDigit();
		public static readonly Optional O = new Optional(S);

		public ZeroDigit()
			: base('0')
		{
		}
	}
}
