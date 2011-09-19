using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class UrlCharacters : ParseMany
	{
		public static readonly UrlCharacters S = new UrlCharacters();
		public static readonly Optional O = new Optional(S);

		public UrlCharacters()
			: base(UrlCharacter.S)
		{
		}
	}
}
