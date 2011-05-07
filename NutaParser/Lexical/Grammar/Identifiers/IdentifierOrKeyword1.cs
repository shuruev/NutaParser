namespace NutaParser.Lexical.Grammar
{
	public class IdentifierOrKeyword1 : LexicalItem
	{
		public static readonly IdentifierOrKeyword1 S = new IdentifierOrKeyword1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				IdentifierStartCharacter.S,
				IdentifierPartCharacters.S);
		}
	}
}
