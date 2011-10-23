using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Directive : ParseAny
	{
		public static readonly Directive S = new Directive();

		public Directive()
			: base(
				ImportSymbol.S,
				PageSymbol.S,
				MediaSymbol.S,
				CharsetSymbol.S,
				NamespaceSymbol.S,
				ImportantSymbol.S)
		{
		}
	}
}
