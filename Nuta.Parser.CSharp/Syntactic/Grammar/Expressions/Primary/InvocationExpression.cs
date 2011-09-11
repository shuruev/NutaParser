using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InvocationExpression : ParseAll
	{
		public static readonly InvocationExpression S = new InvocationExpression();

		public InvocationExpression()
			: base(
				PrimaryExpressionSimple.S,
				new ParseMany(
					new ParseAll(
						PrimaryExpressionSuffixesNotInvocation.O,
						PrimaryExpressionSuffixInvocation.S)))
		{
		}
	}
}
