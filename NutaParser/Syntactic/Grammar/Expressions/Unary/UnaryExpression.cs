namespace NutaParser.Syntactic.Grammar
{
	public class UnaryExpression : ParseAny
	{
		public static readonly UnaryExpression S = new UnaryExpression();

		public UnaryExpression()
			: base(
				PrimaryExpression.S
				/*xxx*/)
		{
		}
	}
}
