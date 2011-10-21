using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class TermPartDimension : ParseAny
	{
		public static readonly TermPartDimension S = new TermPartDimension();

		public TermPartDimension()
			: base(
				new LexicalTerminal(Length.S),
				new LexicalTerminal(Size.S),
				new LexicalTerminal(Angle.S),
				new LexicalTerminal(Time.S),
				new LexicalTerminal(Freq.S),
				new LexicalTerminal(Dimension.S))
		{
		}
	}
}
