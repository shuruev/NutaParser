namespace NutaParser.Syntactic.Grammar
{
	public class ShiftExpression : ParseAny
	{
		public static readonly ShiftExpression S = new ShiftExpression();

		public ShiftExpression()
			: base(
				AdditiveExpression.S
				/*xxx*/)
		{
		}
	}
}
