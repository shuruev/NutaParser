namespace NutaParser.Lexical.Grammar
{
	public class UnicodeEscapeSequence2 : LexicalItem
	{
		public static readonly UnicodeEscapeSequence2 S = new UnicodeEscapeSequence2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				UnicodeEscapeLowerTerminal.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S);
		}
	}
}
