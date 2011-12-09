using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class IdentifierOnly : SpecificIdentifier
	{
		public static readonly IdentifierOnly S = new IdentifierOnly();

		public IdentifierOnly()
			: base(
				LetterO.S,
				LetterN.S,
				LetterL.S,
				LetterY.S)
		{
		}
	}
}
