using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class VerbatimStringLiteralCharacters : ParseMany
	{
		public static readonly VerbatimStringLiteralCharacters S = new VerbatimStringLiteralCharacters();
		public static readonly Optional O = new Optional(S);

		public VerbatimStringLiteralCharacters()
			: base(VerbatimStringLiteralCharacter.S)
		{
		}
	}
}
