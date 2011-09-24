using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class UnaryOperator : ParseAny
	{
		public static readonly UnaryOperator S = new UnaryOperator();

		public UnaryOperator()
			: base(
				new LexicalTerminal(MinusTerminal.S),
				new LexicalTerminal(PlusTerminal.S))
		{
		}
	}
}
