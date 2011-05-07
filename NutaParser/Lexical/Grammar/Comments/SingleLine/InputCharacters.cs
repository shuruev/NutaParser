namespace NutaParser.Lexical.Grammar
{
	public class InputCharacters : LexicalItem
	{
		public static readonly InputCharacters S = new InputCharacters();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, InputCharacter.S);
		}
	}
}
