namespace NutaParser.Lexical.Grammar
{
	public class WarningListDelimiter : LexicalItem
	{
		public static readonly WarningListDelimiter S = new WarningListDelimiter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				WarningListDelimiter1.S,
				WarningListDelimiter2.S,
				WarningListDelimiter3.S,
				CommaTerminal.S);
		}
	}
}
