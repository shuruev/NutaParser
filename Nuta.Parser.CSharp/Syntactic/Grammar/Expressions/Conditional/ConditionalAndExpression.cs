using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ConditionalAndExpression : ParseMany
	{
		public static readonly ConditionalAndExpression S = new ConditionalAndExpression();

		public ConditionalAndExpression()
			: base(
				InclusiveOrExpression.S,
				DoubleAmpersandTerminal.S)
		{
		}
	}
}
