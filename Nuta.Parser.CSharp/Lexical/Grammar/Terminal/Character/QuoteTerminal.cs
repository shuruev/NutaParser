using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class QuoteTerminal : SingleCharacterTerminal
	{
		public static readonly QuoteTerminal S = new QuoteTerminal();

		public QuoteTerminal()
			: base('"')
		{
		}
	}
}
