namespace NutaParser.Lexical.Grammar
{
	public class WarningList : LexicalItem
	{
		public static readonly WarningList S = new WarningList();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, DecimalDigits.S, WarningListDelimiter.S);
		}
	}
}
