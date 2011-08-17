namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryExpression : ParseAny
	{
		public static readonly PrimaryExpression S = new PrimaryExpression();

		public PrimaryExpression()
			: base(
				PrimaryNoArrayCreationExpression.S
				/*xxx*/)
		{
		}
	}
}
