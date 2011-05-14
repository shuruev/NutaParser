namespace NutaParser.Lexical.Grammar
{
	public class DelimitedCommentText : ParseMany
	{
		public static readonly DelimitedCommentText S = new DelimitedCommentText();
		public static readonly Optional O = new Optional(S);

		public DelimitedCommentText()
			: base(DelimitedCommentSection.S)
		{
		}
	}
}
