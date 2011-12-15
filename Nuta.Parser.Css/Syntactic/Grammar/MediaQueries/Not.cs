using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class Not : SpecificIdentifier
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
