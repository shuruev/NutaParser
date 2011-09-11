using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
