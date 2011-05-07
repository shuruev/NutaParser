namespace NutaParser.Lexical.Grammar
{
	public class AsteriskTerminal : LexicalItem
	{
		public static readonly AsteriskTerminal S = new AsteriskTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, '*');
		}
	}
}
