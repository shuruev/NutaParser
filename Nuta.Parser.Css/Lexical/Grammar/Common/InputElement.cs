using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class InputElement : ParseAny
	{
		public static readonly InputElement S = new InputElement();

		public InputElement()
			: base(
				Whitespace.S,
				Comment.S,
				CommentDelimiterOpen.S,
				CommentDelimiterClose.S,
				OperatorOrPunctuator.S,
				LiteralOrIdentifier.S,
				Directive.S,
				FunctionPrefix.S)
		{
		}
	}
}
