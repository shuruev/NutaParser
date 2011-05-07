namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalEscapeTerminal : LexicalItem
	{
		public static readonly HexadecimalEscapeTerminal S = new HexadecimalEscapeTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, @"\x");
		}
	}
}
