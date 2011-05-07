namespace NutaParser.Lexical.Grammar
{
	public class SharpTerminal : LexicalItem
	{
		public static readonly SharpTerminal S = new SharpTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, '#');
		}
	}
}
