namespace NutaParser.Lexical.Grammar
{
	public class LineIndicator1 : LexicalItem
	{
		public static readonly LineIndicator1 S = new LineIndicator1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				DecimalDigits.S,
				Whitespace.S,
				FileName.S);
		}
	}
}
