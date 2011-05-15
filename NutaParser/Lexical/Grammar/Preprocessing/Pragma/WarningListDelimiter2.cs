namespace NutaParser.Lexical.Grammar
{
	public class WarningListDelimiter2 : LexicalItem
	{
		public static readonly WarningListDelimiter2 S = new WarningListDelimiter2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				CommaTerminal.S);
		}
	}
}
