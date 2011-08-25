namespace NutaParser.Syntactic.Grammar
{
	public class NonAssignmentExpression : ParseAny
	{
		public static readonly NonAssignmentExpression S = new NonAssignmentExpression();

		public NonAssignmentExpression()
			: base(
				ConditionalExpression.S,
				LambdaExpression.S
				/*xxxQUERY*/)
		{
		}
	}
}
