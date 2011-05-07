namespace NutaParser.Lexical.Grammar
{
	public class PeriodTerminal : LexicalItem
	{
		public static readonly PeriodTerminal S = new PeriodTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, '.');
		}
	}
}
