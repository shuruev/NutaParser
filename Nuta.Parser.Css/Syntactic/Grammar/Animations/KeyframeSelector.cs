using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class KeyframeSelector : ParseAny
	{
		public static readonly KeyframeSelector S = new KeyframeSelector();

		public KeyframeSelector()
			: base(
				From.S,
				To.S,
				new LexicalTerminal(Percentage.S))
		{
		}
	}
}
