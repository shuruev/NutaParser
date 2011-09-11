using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class HexadecimalEscapeSequence : ParseAll
	{
		public static readonly HexadecimalEscapeSequence S = new HexadecimalEscapeSequence();

		public HexadecimalEscapeSequence()
			: base(
					BackslashTerminal.S,
					new SingleCharacterTerminal('x'),
					HexDigit.S,
					HexDigit.O,
					HexDigit.O,
					HexDigit.O)
		{
		}
	}
}
