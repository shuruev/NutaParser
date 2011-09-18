using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class UnicodeWhitespace : ParseAny
	{
		public static readonly UnicodeWhitespace S = new UnicodeWhitespace();
		public static readonly Optional O = new Optional(S);

		public UnicodeWhitespace()
			: base(
				NewLine.S,
				WhitespaceCharacter.S)
		{
		}
	}
}
