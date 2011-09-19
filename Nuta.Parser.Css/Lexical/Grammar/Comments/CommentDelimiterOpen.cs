using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class CommentDelimiterOpen : SingleWordTerminal
	{
		public static readonly CommentDelimiterOpen S = new CommentDelimiterOpen();

		public CommentDelimiterOpen()
			: base("<!--")
		{
		}
	}
}
