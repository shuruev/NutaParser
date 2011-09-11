using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class PpEqualityExpression : ParseMany
	{
		public static readonly PpEqualityExpression S = new PpEqualityExpression();

		public PpEqualityExpression()
			: base(
				PpUnaryExpression.S,
				new ParseAll(
					Whitespace.O,
					new ParseAny(EqualOperatorTerminal.S, NotEqualOperatorTerminal.S),
					Whitespace.O))
		{
		}
	}
}
