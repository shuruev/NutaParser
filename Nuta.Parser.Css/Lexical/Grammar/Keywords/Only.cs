using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Only : ParseAll
	{
		public static readonly Only S = new Only();

		public Only()
			: base(
				LetterO.S,
				LetterN.S,
				LetterL.S,
				LetterY.S)
		{
		}
	}
}
