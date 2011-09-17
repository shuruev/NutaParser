using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class String1 : ParseAll
	{
		public static readonly String1 S = new String1();

		public String1()
			: base(
				QuoteTerminal.S,
				String1Characters.O,
				QuoteTerminal.S)
		{
		}
	}
}
