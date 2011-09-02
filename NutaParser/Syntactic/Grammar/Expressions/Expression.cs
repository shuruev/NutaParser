namespace NutaParser.Syntactic.Grammar
{
	public class Expression : SyntacticItem
	{
		public static readonly Expression S = new Expression();
		public static readonly Optional O = new Optional(S);

		public override bool Parse(SyntacticState state)
		{
			return ParseAny(
				state,
				/*xxxAssignment.S,*/
				NonAssignmentExpression.S);
		}
	}
}
