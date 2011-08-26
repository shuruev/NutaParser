namespace NutaParser.Syntactic.Grammar
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
