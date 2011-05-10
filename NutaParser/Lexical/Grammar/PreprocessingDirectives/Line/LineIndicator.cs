namespace NutaParser.Lexical.Grammar
{
	public class LineIndicator : LexicalItem
	{
		public static readonly LineIndicator S = new LineIndicator();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				LineIndicator1.S,
				DecimalDigits.S,
				DefaultTerminal.S,
				HiddenTerminal.S);
		}
	}
}
