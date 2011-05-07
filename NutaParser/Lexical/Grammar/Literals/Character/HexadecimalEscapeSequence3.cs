namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalEscapeSequence3 : LexicalItem
	{
		public static readonly HexadecimalEscapeSequence3 S = new HexadecimalEscapeSequence3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				HexadecimalEscapeTerminal.S,
				HexDigit.S,
				HexDigit.S);
		}
	}
}
