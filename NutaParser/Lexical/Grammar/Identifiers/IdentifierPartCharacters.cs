namespace NutaParser.Lexical.Grammar
{
	public class IdentifierPartCharacters : LexicalItem
	{
		public static readonly IdentifierPartCharacters S = new IdentifierPartCharacters();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, IdentifierPartCharacter.S);
		}
	}
}
