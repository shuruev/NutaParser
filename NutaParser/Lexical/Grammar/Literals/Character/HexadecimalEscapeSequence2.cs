namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalEscapeSequence2 : LexicalItem
	{
		public static readonly HexadecimalEscapeSequence2 S = new HexadecimalEscapeSequence2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				HexadecimalEscapeTerminal.S,
				HexDigit.S,
				HexDigit.S,
				HexDigit.S);
		}
	}
}
