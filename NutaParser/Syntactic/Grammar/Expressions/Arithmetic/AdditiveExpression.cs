namespace NutaParser.Syntactic.Grammar
{
	public class AdditiveExpression : ParseMany
	{
		public static readonly AdditiveExpression S = new AdditiveExpression();

		public AdditiveExpression()
			: base(
				MultiplicativeExpression.S,
				new ParseAny(
					PlusTerminal.S,
					MinusTerminal.S))
		{
		}
	}
}
