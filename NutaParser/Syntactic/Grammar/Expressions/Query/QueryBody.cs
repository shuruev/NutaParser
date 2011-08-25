namespace NutaParser.Syntactic.Grammar
{
	public class QueryBody : ParseAll
	{
		public static readonly QueryBody S = new QueryBody();

		public QueryBody()
			: base(
				QueryBodyClauses.O,
				SelectOrGroupClause.S,
				QueryContinuation.O)
		{
		}
	}
}
