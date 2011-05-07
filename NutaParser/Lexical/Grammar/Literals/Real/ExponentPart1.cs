namespace NutaParser.Lexical.Grammar
{
	public class ExponentPart1 : LexicalItem
	{
		public static readonly ExponentPart1 S = new ExponentPart1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				ExponentPrefixTerminal.S,
				Sign.S,
				DecimalDigits.S);
		}
	}
}
