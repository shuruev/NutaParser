namespace NutaParser.Lexical.Grammar
{
	public class DelimitedCommentText : LexicalItem
	{
		public static readonly DelimitedCommentText S = new DelimitedCommentText();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, DelimitedCommentSection.S);
		}
	}
}
