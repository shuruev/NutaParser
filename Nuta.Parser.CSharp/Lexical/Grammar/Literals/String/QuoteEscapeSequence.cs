using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class QuoteEscapeSequence : ParseAll
	{
		public static readonly QuoteEscapeSequence S = new QuoteEscapeSequence();

		public QuoteEscapeSequence()
			: base(QuoteTerminal.S, QuoteTerminal.S)
		{
		}
	}
}
