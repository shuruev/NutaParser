namespace NutaParser.Lexical.Grammar
{
	public class ExponentPart2 : LexicalItem
	{
		public static readonly ExponentPart2 S = new ExponentPart2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				ExponentPrefixTerminal.S,
				DecimalDigits.S);
		}
	}
}
