using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class PseudoExpression : ParseMany
	{
		public static readonly PseudoExpression S = new PseudoExpression();

		public PseudoExpression()
			: base(
				new ParseAny(
					new LexicalTerminal(StringLiteral.S),
					new LexicalTerminal(Identifier.S),
					TermPartDimension.S,
					new LexicalTerminal(Number.S),
					PlusTerminal.S,
					MinusTerminal.S),
				WhitespaceTerminal.O)
		{
		}
	}
}
