using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
