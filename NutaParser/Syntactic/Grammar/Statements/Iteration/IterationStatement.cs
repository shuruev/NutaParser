namespace NutaParser.Syntactic.Grammar
{
	public class IterationStatement : ParseAny
	{
		public static readonly IterationStatement S = new IterationStatement();

		public IterationStatement()
			: base(
				WhileStatement.S,
				DoStatement.S,
				ForStatement.S,
				ForeachStatement.S)
		{
		}
	}
}
