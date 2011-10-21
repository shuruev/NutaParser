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
				WhitespaceTerminal.O,
				PseudoExpression.S,
				WhitespaceTerminal.O,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
