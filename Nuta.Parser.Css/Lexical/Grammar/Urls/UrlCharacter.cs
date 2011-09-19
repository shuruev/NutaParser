using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class UrlCharacter : ParseAny
	{
		public static readonly UrlCharacter S = new UrlCharacter();

		public UrlCharacter()
			: base(
				Escape.S,
				NonAscii.S,
				new SingleCharacterTerminal('!', '#', '$', '%', '&'),
				new FuncCharacterTerminal(c => c >= 42 && c <= 126))
		{
		}
	}
}
