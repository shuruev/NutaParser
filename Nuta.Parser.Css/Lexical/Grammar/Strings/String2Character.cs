using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class String2Character : ParseAny
	{
		public static readonly String2Character S = new String2Character();

		public String2Character()
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
						ApostropheTerminal.S)))
		{
		}
	}
}
