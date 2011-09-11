using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InclusiveOrExpression : ParseMany
	{
		public static readonly InclusiveOrExpression S = new InclusiveOrExpression();

		public InclusiveOrExpression()
			: base(
				ExclusiveOrExpression.S,
				BarTerminal.S)
		{
		}
	}
}
