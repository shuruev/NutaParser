namespace NutaParser.Syntactic.Grammar
{
	public class QueryBodyClause : ParseAny
	{
		public static readonly QueryBodyClause S = new QueryBodyClause();

		public QueryBodyClause()
			: base(
				FromClause.S,
				LetClause.S,
				WhereClause.S,
				JoinIntoClause.S,
				JoinClause.S,
				OrderbyClause.S)
		{
		}
	}
}
