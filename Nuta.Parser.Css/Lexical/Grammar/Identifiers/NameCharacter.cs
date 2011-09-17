using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NameCharacter : ParseAny
	{
		public static readonly NameCharacter S = new NameCharacter();

		public NameCharacter()
			: base(
				UnderscoreTerminal.S,
				HyphenTerminal.S,
				AsciiLetter.S,
				AsciiDigit.S,
				NonAscii.S,
				Escape.S)
		{
		}
	}
}
