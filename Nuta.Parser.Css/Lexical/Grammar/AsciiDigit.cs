using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class AsciiDigit : SingleCharacterTerminal
	{
		public static readonly AsciiDigit S = new AsciiDigit();

		public AsciiDigit()
			: base(
				'0',
				'1',
				'2',
				'3',
				'4',
				'5',
				'6',
				'7',
				'8',
				'9')
		{
		}
	}
}
