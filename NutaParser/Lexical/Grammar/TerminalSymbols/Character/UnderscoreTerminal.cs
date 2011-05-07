namespace NutaParser.Lexical.Grammar
{
	public class UnderscoreTerminal : LexicalItem
	{
		public static readonly UnderscoreTerminal S = new UnderscoreTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, '_');
		}
	}
}
