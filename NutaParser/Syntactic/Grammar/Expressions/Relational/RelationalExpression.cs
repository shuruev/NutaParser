namespace NutaParser.Syntactic.Grammar
{
	public class RelationalExpression : ParseAny
	{
		public static readonly RelationalExpression S = new RelationalExpression();

		public RelationalExpression()
			: base(
				ShiftExpression.S
				/*xxx*/)
		{
		}
	}
}
