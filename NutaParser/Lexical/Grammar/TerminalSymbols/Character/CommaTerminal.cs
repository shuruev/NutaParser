namespace NutaParser.Lexical.Grammar
{
	public class CommaTerminal : LexicalItem
	{
		public static readonly CommaTerminal S = new CommaTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, ',');
		}
	}
}
