namespace NutaParser.Syntactic.Grammar
{
	public class Assignment : ParseAll
	{
		public static readonly Assignment S = new Assignment();

		public Assignment()
			: base(
				UnaryExpression.S,
				AssignmentOperator.S,
				Expression.S)
		{
		}
	}
}
