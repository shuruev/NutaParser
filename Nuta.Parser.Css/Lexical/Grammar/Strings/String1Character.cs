using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class String1Character : ParseAny
	{
		public static readonly String1Character S = new String1Character();

		public String1Character()
			: base(
				Escape.S,
				new ParseAll(
					BackslashTerminal.S,
					NewLine.S),
				new ParseExcept(
					AnyCharacterTerminal.S,
					new ParseAny(
						CarriageReturnTerminal.S,
						LineFeedTerminal.S,
						FormFeedTerminal.S,
						BackslashTerminal.S,
						QuoteTerminal.S)))
		{
		}
	}
}
