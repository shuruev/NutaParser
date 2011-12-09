using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class IdentifierNot : SpecificIdentifier
	{
		public static readonly IdentifierNot S = new IdentifierNot();

		public IdentifierNot()
			: base(
				LetterN.S,
				LetterO.S,
				LetterT.S)
		{
		}
	}
}
