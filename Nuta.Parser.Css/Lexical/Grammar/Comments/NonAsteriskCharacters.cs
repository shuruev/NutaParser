using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NonAsteriskCharacters : ParseMany
	{
		public static readonly NonAsteriskCharacters S = new NonAsteriskCharacters();
		public static readonly Optional O = new Optional(S);

		public NonAsteriskCharacters()
			: base(
				new ParseExcept(
					AnyCharacterTerminal.S,
					AsteriskTerminal.S))
		{
		}
	}
}
