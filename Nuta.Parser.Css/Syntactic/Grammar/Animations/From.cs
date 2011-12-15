using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class From : SpecificIdentifier
	{
		public static readonly From S = new From();

		public From()
			: base(
				LetterF.S,
				LetterR.S,
				LetterO.S,
				LetterM.S)
		{
		}
	}
}
