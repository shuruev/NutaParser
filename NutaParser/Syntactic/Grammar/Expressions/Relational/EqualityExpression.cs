namespace NutaParser.Syntactic.Grammar
{
	public class EqualityExpression : ParseAny
	{
		public static readonly EqualityExpression S = new EqualityExpression();

		public EqualityExpression()
			: base(
				RelationalExpression.S
				/*xxx*/)
		{
		}
	}
}
