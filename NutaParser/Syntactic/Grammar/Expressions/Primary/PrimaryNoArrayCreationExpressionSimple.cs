using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryNoArrayCreationExpressionSimple : SyntacticItem
	{
		public static readonly PrimaryNoArrayCreationExpressionSimple S = new PrimaryNoArrayCreationExpressionSimple();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				LiteralTerminal.S,
				MemberAccessSimple.S,
				SimpleName.S,
				ParenthesizedExpression.S,
				ThisAccess.S,
				BaseAccess.S,
				ObjectCreationExpression.S,
				DelegateCreationExpression.S,
				AnonymousObjectCreationExpression.S,
				TypeofExpression.S,
				CheckedExpression.S,
				UncheckedExpression.S,
				DefaultValueExpression.S,
				AnonymousMethodExpression.S,
				ArrayCreationExpression.S);
		}
	}
}
