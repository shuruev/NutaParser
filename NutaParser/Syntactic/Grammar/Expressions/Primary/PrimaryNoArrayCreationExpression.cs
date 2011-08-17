namespace NutaParser.Syntactic.Grammar
{
	public class PrimaryNoArrayCreationExpression : SyntacticItem
	{
		public static readonly PrimaryNoArrayCreationExpression S = new PrimaryNoArrayCreationExpression();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				LiteralTerminal.S,
				SimpleName.S,
				ParenthesizedExpression.S,
				MemberAccess.S
				/*xxx*/);
		}
	}
}
