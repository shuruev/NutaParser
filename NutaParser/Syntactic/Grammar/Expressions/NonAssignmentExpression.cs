using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class NonAssignmentExpression : ParseAny
	{
		public static readonly NonAssignmentExpression S = new NonAssignmentExpression();

		public NonAssignmentExpression()
			: base(
				QueryExpression.S,
				LambdaExpression.S,
				ConditionalExpression.S)
		{
		}
	}
}
