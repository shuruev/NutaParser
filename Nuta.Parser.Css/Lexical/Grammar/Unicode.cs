using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Unicode : ParseAll
	{
		public static readonly Unicode S = new Unicode();

		public Unicode()
			: base(
				BackslashTerminal.S,
				HexDigit.S,
				HexDigit.O,
				HexDigit.O,
				HexDigit.O,
				HexDigit.O,
				HexDigit.O,
				new ParseAny(
					NewLine.S,
					WhitespaceCharacter.S,
					Empty.S))
		{
		}
	}
}
