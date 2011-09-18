using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Escape : ParseAny
	{
		public static readonly Escape S = new Escape();

		public Escape()
			: base(
				Unicode.S,
				new ParseAll(
					BackslashTerminal.S,
					new ParseExcept(
						AnyCharacterTerminal.S,
						new ParseAny(
							CarriageReturnTerminal.S,
							LineFeedTerminal.S,
							FormFeedTerminal.S,
							HexDigit.S))))
		{
		}
	}
}
