namespace NutaParser.Lexical.Grammar
{
	public class UnicodeEscapeSequence1 : LexicalItem
	{
		public static readonly UnicodeEscapeSequence1 S = new UnicodeEscapeSequence1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				UnicodeEscapeUpperTerminal.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S);
		}
	}
}
