namespace NutaParser.Syntactic.Grammar
{
	public class EqualityExpression : ParseMany
	{
		public static readonly EqualityExpression S = new EqualityExpression();

		public EqualityExpression()
			: base(
				RelationalExpression.S,
				new ParseAny(
					DoubleEqualTerminal.S,
					NotEqualTerminal.S))
		{
		}
	}
}
