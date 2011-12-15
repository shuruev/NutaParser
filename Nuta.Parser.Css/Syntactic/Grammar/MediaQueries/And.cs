using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class And : SpecificIdentifier
	{
		public static readonly And S = new And();

		public And()
			: base(
				LetterA.S,
				LetterN.S,
				LetterD.S)
		{
		}
	}
}
