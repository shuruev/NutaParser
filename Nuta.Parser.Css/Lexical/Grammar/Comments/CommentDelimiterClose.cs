using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class CommentDelimiterClose : SingleWordTerminal
	{
		public static readonly CommentDelimiterClose S = new CommentDelimiterClose();

		public CommentDelimiterClose()
			: base("-->")
		{
		}
	}
}
