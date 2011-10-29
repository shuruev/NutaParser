using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class PseudoFunction : ParseAll
	{
		public static readonly PseudoFunction S = new PseudoFunction();

		public PseudoFunction()
			: base(
				new LexicalTerminal(FunctionPrefix.S),
				Whitespaces.O,
				PseudoExpression.S,
				Whitespaces.O,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
