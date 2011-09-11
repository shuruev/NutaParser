using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class StatementExpressionList : ParseMany
	{
		public static readonly StatementExpressionList S = new StatementExpressionList();

		public StatementExpressionList()
			: base(StatementExpression.S, CommaTerminal.S)
		{
		}
	}
}
