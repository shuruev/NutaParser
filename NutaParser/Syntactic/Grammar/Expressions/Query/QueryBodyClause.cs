namespace NutaParser.Syntactic.Grammar
{
	public class QueryBodyClause : SyntacticItem
	{
		public static readonly QueryBodyClause S = new QueryBodyClause();

		public override bool Parse(SyntacticState state)
		{
			// this is a special case when we want to
			// prohibit using LINQ keywords as identifiers
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
