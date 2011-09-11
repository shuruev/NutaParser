using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class IdentifierPartCharacters : ParseMany
	{
		public static readonly IdentifierPartCharacters S = new IdentifierPartCharacters();
		public static readonly Optional O = new Optional(S);

		public IdentifierPartCharacters()
			: base(IdentifierPartCharacter.S)
		{
		}
	}
}
