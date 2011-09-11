using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
