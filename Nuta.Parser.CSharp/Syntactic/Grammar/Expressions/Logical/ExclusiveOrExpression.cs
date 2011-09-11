using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ExclusiveOrExpression : ParseMany
	{
		public static readonly ExclusiveOrExpression S = new ExclusiveOrExpression();

		public ExclusiveOrExpression()
			: base(
				AndExpression.S,
				CaretTerminal.S)
		{
		}
	}
}
