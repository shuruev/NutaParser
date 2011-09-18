using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Number : ParseAny
	{
		public static readonly Number S = new Number();

		public Number()
			: base(
				new ParseAll(
					AsciiDigits.O,
					PeriodTerminal.S,
					AsciiDigits.S),
				AsciiDigits.S)
		{
		}
	}
}
