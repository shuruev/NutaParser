namespace NutaParser.Lexical.Grammar
{
	public class WarningListDelimiter3 : LexicalItem
	{
		public static readonly WarningListDelimiter3 S = new WarningListDelimiter3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				CommaTerminal.S,
				Whitespace.S);
		}
	}
}
