using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class CommentParts : ParseMany
	{
		public static readonly CommentParts S = new CommentParts();
		public static readonly Optional O = new Optional(S);

		public CommentParts()
			: base(CommentPart.S)
		{
		}
	}
}
