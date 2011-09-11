using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
