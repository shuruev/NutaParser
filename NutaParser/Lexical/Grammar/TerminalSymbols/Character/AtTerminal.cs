namespace NutaParser.Lexical.Grammar
{
	public class AtTerminal : LexicalItem
	{
		public static readonly AtTerminal S = new AtTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, '@');
		}
	}
}
