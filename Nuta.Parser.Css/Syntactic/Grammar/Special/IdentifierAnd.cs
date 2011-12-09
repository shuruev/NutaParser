using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class IdentifierAnd : SpecificIdentifier
	{
		public static readonly IdentifierAnd S = new IdentifierAnd();

		public IdentifierAnd()
			: base(
				LetterA.S,
				LetterN.S,
				LetterD.S)
		{
		}
	}
}
