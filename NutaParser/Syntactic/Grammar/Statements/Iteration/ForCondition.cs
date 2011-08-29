namespace NutaParser.Syntactic.Grammar
{
	public class ForCondition : ParseAll
	{
		public static readonly ForCondition S = new ForCondition();
		public static readonly Optional O = new Optional(S);

		public ForCondition()
			: base(BooleanExpression.S)
		{
		}
	}
}
