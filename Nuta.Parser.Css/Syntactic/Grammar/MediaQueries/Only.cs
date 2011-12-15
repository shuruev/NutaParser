using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class Only : SpecificIdentifier
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
