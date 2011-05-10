namespace NutaParser.Lexical.Grammar
{
	public class FileNameCharacters : LexicalItem
	{
		public static readonly FileNameCharacters S = new FileNameCharacters();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, FileNameCharacter.S);
		}
	}
}
