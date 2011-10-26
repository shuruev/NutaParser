using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class StylesheetWhitespace : ParseMany
	{
		public static readonly StylesheetWhitespace S = new StylesheetWhitespace();
		public static readonly Optional O = new Optional(S);

		public StylesheetWhitespace()
			: base(
				new ParseAny(
					WhitespaceTerminal.S,
					new LexicalTerminal(CommentDelimiterOpen.S),
					new LexicalTerminal(CommentDelimiterClose.S)))
		{
		}
	}
}
