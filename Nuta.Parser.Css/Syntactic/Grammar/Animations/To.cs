using Nuta.Parser.Css.Lexical;

namespace Nuta.Parser.Css.Syntactic
{
	public class To : SpecificIdentifier
	{
		public static readonly To S = new To();

		public To()
			: base(
				LetterT.S,
				LetterO.S)
		{
		}
	}
}
