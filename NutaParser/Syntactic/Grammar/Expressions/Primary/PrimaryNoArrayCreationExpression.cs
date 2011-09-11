using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryNoArrayCreationExpression : SyntacticItem
	{
		public static readonly PrimaryNoArrayCreationExpression S = new PrimaryNoArrayCreationExpression();

		public override bool Parse(SyntacticState state)
		{
			return ParseAll(
				state,
				PrimaryNoArrayCreationExpressionSimple.S,
				PrimaryExpressionSuffixes.O);
		}
	}
}
