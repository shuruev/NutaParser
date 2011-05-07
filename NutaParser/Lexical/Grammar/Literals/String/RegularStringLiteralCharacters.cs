namespace NutaParser.Lexical.Grammar
{
	public class RegularStringLiteralCharacters : LexicalItem
	{
		public static readonly RegularStringLiteralCharacters S = new RegularStringLiteralCharacters();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, RegularStringLiteralCharacter.S);
		}
	}
}
