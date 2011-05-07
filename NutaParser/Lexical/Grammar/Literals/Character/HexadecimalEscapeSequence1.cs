namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalEscapeSequence1 : LexicalItem
	{
		public static readonly HexadecimalEscapeSequence1 S = new HexadecimalEscapeSequence1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				HexadecimalEscapeTerminal.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S);
		}
	}
}
