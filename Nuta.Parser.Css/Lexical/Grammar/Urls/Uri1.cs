using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Uri1 : ParseAll
	{
		public static readonly Uri1 S = new Uri1();

		public Uri1()
			: base(
				LetterU.S,
				LetterR.S,
				LetterL.S,
				LeftRoundBracketTerminal.S,
				Whitespace.O,
				StringLiteral.S,
				Whitespace.O,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
