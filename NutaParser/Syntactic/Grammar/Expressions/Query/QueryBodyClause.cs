namespace NutaParser.Syntactic.Grammar
{
	public class QueryBodyClause : SyntacticItem
	{
		public static readonly QueryBodyClause S = new QueryBodyClause();

		public override bool Parse(SyntacticState state)
		{
			state.RaiseFlag(StateFlags.InsideLinq);

			bool parsed = ParseAny(
				state,
				FromClause.S,
				LetClause.S,
				WhereClause.S,
				JoinIntoClause.S,
				JoinClause.S,
				OrderbyClause.S);

			state.LowerFlag(StateFlags.InsideLinq);
			return parsed;
		}
	}
}
