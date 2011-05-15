namespace NutaParser.Lexical.Grammar
{
	public class UnicodeEscapeSequence : ParseAny
	{
		public static readonly UnicodeEscapeSequence S = new UnicodeEscapeSequence();

		public UnicodeEscapeSequence()
			: base(
				new ParseAll(
					BackslashTerminal.S,
					new SingleCharacterTerminal('U'),
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S),
				new ParseAll(
					BackslashTerminal.S,
					new SingleCharacterTerminal('u'),
					HexDigit.S,
					HexDigit.S,
					HexDigit.S,
					HexDigit.S))
		{
		}
	}
}
