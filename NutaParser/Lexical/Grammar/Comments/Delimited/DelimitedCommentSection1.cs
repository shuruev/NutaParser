namespace NutaParser.Lexical.Grammar
{
	public class DelimitedCommentSection1 : LexicalItem
	{
		public static readonly DelimitedCommentSection1 S = new DelimitedCommentSection1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Asterisks.S,
				NotSlashOrAsterisk.S);
		}
	}
}
