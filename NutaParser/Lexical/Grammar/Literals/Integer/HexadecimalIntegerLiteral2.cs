namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalIntegerLiteral2 : LexicalItem
	{
		public static readonly HexadecimalIntegerLiteral2 S = new HexadecimalIntegerLiteral2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				HexadecimalPrefixTerminal.S,
				HexDigits.S);
		}
	}
}
