namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalPrefixTerminal : LexicalItem
	{
		public static readonly HexadecimalPrefixTerminal S = new HexadecimalPrefixTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(
				state,
				"0x",
				"0X");
		}
	}
}
