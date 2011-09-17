using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NameStart : ParseAny
	{
		public static readonly NameStart S = new NameStart();

		public NameStart()
			: base(
				UnderscoreTerminal.S,
				AsciiLetter.S,
				NonAscii.S,
				Escape.S)
		{
		}
	}
}
