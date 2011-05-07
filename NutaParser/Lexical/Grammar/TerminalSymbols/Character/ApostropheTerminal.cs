namespace NutaParser.Lexical.Grammar
{
	public class ApostropheTerminal : LexicalItem
	{
		public static readonly ApostropheTerminal S = new ApostropheTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, '\'');
		}
	}
}
