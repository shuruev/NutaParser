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
				IncludesOperatorTerminal.S,
				DashmatchOperatorTerminal.S,
				PrefixmatchOperatorTerminal.S,
				SuffixmatchOperatorTerminal.S,
				SubstringmatchOperatorTerminal.S,
				UriLiteral.S,
				FunctionPrefix.S,
				NotPrefix.S,
				AtKeyword.S,
				StringLiteral.S,
				NumericLiteral.S,
				Hash.S,
				Identifier.S,
				Punctuator.S,
				Directive.S)
		{
		}
	}
}
