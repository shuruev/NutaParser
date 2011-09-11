using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class RegularStringLiteralCharacters : ParseMany
	{
		public static readonly RegularStringLiteralCharacters S = new RegularStringLiteralCharacters();
		public static readonly Optional O = new Optional(S);

		public RegularStringLiteralCharacters()
			: base(RegularStringLiteralCharacter.S)
		{
		}
	}
}
