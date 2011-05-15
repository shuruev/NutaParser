namespace NutaParser.Lexical.Grammar
{
	public class WarningList : ParseMany
	{
		public static readonly WarningList S = new WarningList();

		public WarningList()
			: base(
				DecimalDigits.S,
				new ParseAll(Whitespace.O, CommaTerminal.S, Whitespace.O))
		{
		}
	}
}
