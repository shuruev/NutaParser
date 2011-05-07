namespace NutaParser.Lexical.Grammar
{
	public class SlashTerminal : LexicalItem
	{
		public static readonly SlashTerminal S = new SlashTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, '/');
		}
	}
}
