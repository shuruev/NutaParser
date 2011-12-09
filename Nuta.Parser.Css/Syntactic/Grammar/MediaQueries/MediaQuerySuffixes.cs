using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaQuerySuffixes : ParseMany
	{
		public static readonly MediaQuerySuffixes S = new MediaQuerySuffixes();
		public static readonly Optional O = new Optional(S);

		public MediaQuerySuffixes()
			: base(
				new ParseAll(
					IdentifierAnd.S,
					Whitespaces.O,
					MediaExpression.S))
		{
		}
	}
}
