namespace NutaParser.Lexical.Grammar
{
	public class WarningTerminal : LexicalItem
	{
		public static readonly WarningTerminal S = new WarningTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "warning");
		}
	}
}
