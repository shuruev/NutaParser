using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class LiteralOrIdentifier : ParseAny
	{
		public static readonly LiteralOrIdentifier S = new LiteralOrIdentifier();

		public LiteralOrIdentifier()
			: base(
				UriLiteral.S,
				StringLiteral.S,
				NumericLiteral.S,
				Hash.S,
				Identifier.S)
		{
		}
	}
}
