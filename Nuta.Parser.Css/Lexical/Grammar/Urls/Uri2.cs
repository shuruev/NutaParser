using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Uri2 : ParseAll
	{
		public static readonly Uri2 S = new Uri2();

		public Uri2()
			: base(
				LetterU.S,
				LetterR.S,
				LetterL.S,
				LeftRoundBracketTerminal.S,
				Whitespace.O,
				UrlCharacters.O,
				Whitespace.O,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
