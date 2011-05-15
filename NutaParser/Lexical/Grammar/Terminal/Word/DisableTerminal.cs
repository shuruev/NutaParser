namespace NutaParser.Lexical.Grammar
{
	public class DisableTerminal : LexicalItem
	{
		public static readonly DisableTerminal S = new DisableTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "disable");
		}
	}
}
