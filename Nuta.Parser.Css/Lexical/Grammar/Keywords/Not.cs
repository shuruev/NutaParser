using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Not : ParseAll
	{
		public static readonly Not S = new Not();

		public Not()
			: base(
				LetterN.S,
				LetterO.S,
				LetterT.S)
		{
		}
	}
}
