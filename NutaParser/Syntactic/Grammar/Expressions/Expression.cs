namespace NutaParser.Syntactic.Grammar
{
	public class Expression : SyntacticItem
	{
		public static readonly Expression S = new Expression();

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				Assignment.S,
				NonAssignmentExpression.S);
		}
	}
}
