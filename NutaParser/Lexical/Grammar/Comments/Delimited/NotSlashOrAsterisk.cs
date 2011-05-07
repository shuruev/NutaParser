namespace NutaParser.Lexical.Grammar
{
	public class NotSlashOrAsterisk : LexicalItem
	{
		public static readonly NotSlashOrAsterisk S = new NotSlashOrAsterisk();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => c != '/' && c != '*');
		}
	}
}
