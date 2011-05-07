namespace NutaParser.Lexical.Grammar
{
	public class WarningListDelimiter1 : LexicalItem
	{
		public static readonly WarningListDelimiter1 S = new WarningListDelimiter1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				CommaTerminal.S,
				Whitespace.S);
		}
	}
}
