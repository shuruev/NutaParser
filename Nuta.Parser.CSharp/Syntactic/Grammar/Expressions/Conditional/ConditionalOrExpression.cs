using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ConditionalOrExpression : ParseMany
	{
		public static readonly ConditionalOrExpression S = new ConditionalOrExpression();

		public ConditionalOrExpression()
			: base(
				ConditionalAndExpression.S,
				DoubleBarTerminal.S)
		{
		}
	}
}
