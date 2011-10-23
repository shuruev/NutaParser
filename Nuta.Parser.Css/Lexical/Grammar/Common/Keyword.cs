using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Keyword : ParseAny
	{
		public static readonly Keyword S = new Keyword();

		public Keyword()
			: base(
				ImportantSymbol.S,
				FunctionPrefix.S,
				NotPrefix.S,
				AtKeyword.S,
				Only.S,
				Not.S,
				And.S)
		{
		}
	}
}
