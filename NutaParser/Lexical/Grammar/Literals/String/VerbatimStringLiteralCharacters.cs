namespace NutaParser.Lexical.Grammar
{
	public class VerbatimStringLiteralCharacters : LexicalItem
	{
		public static readonly VerbatimStringLiteralCharacters S = new VerbatimStringLiteralCharacters();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, VerbatimStringLiteralCharacter.S);
		}
	}
}
