using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ExpressionList : ParseMany
	{
		public static readonly ExpressionList S = new ExpressionList();

		public ExpressionList()
			: base(Expression.S, CommaTerminal.S)
		{
		}
	}
}
