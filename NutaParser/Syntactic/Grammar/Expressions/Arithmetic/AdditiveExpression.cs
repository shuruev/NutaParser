namespace NutaParser.Syntactic.Grammar
{
	public class AdditiveExpression : ParseAny
	{
		public static readonly AdditiveExpression S = new AdditiveExpression();

		public AdditiveExpression()
			: base(
				MultiplicativeExpression.S
				/*xxx*/)
		{
		}
	}
}
