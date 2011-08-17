namespace NutaParser.Syntactic.Grammar
{
	public class MultiplicativeExpression : ParseAny
	{
		public static readonly MultiplicativeExpression S = new MultiplicativeExpression();

		public MultiplicativeExpression()
			: base(
				UnaryExpression.S
				/*xxx*/)
		{
		}
	}
}
