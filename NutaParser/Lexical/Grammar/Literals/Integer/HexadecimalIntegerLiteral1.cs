namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalIntegerLiteral1 : LexicalItem
	{
		public static readonly HexadecimalIntegerLiteral1 S = new HexadecimalIntegerLiteral1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				HexadecimalPrefixTerminal.S,
				HexDigits.S,
				IntegerTypeSuffix.S);
		}
	}
}
