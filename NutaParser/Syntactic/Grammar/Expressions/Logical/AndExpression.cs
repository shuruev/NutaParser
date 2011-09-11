using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AndExpression : ParseMany
	{
		public static readonly AndExpression S = new AndExpression();

		public AndExpression()
			: base(
				EqualityExpression.S,
				AmpersandTerminal.S)
		{
		}
	}
}
