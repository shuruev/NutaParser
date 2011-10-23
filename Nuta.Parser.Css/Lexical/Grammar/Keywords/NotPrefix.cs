using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NotPrefix : ParseAll
	{
		public static readonly NotPrefix S = new NotPrefix();

		public NotPrefix()
			: base(
				ColonTerminal.S,
				LetterN.S,
				LetterO.S,
				LetterT.S,
				LeftRoundBracketTerminal.S)
		{
		}
	}
}
