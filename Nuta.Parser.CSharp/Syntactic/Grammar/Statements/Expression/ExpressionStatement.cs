using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ExpressionStatement : ParseAll
	{
		public static readonly ExpressionStatement S = new ExpressionStatement();

		public ExpressionStatement()
			: base(
				StatementExpression.S,
				SemicolonTerminal.S)
		{
		}
	}
}
