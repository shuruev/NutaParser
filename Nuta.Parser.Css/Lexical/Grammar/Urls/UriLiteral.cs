using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class UriLiteral : ParseAny
	{
		public static readonly UriLiteral S = new UriLiteral();

		public UriLiteral()
			: base(
				Uri1.S,
				Uri2.S)
		{
		}
	}
}
