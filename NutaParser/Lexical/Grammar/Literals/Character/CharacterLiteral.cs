namespace NutaParser.Lexical.Grammar
{
	public class CharacterLiteral : LexicalItem
	{
		public static readonly CharacterLiteral S = new CharacterLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				ApostropheTerminal.S,
				Character.S,
				ApostropheTerminal.S);
		}
	}
}
