namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalEscapeSequence4 : LexicalItem
	{
		public static readonly HexadecimalEscapeSequence4 S = new HexadecimalEscapeSequence4();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				HexadecimalEscapeTerminal.S,
				HexDigit.S);
		}
	}
}
