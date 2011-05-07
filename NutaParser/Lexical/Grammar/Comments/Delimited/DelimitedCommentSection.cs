namespace NutaParser.Lexical.Grammar
{
	public class DelimitedCommentSection : LexicalItem
	{
		public static readonly DelimitedCommentSection S = new DelimitedCommentSection();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				DelimitedCommentSection1.S,
				SlashTerminal.S,
				NotSlashOrAsterisk.S);
		}
	}
}
