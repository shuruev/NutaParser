using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class RelationalExpression : ParseAll
	{
		public static readonly RelationalExpression S = new RelationalExpression();

		public RelationalExpression()
			: base(
				ShiftExpression.S,
				new ParseAny(
					new ParseMany(RelationalExpressionPart.S),
					Empty.S))
		{
		}
	}
}
