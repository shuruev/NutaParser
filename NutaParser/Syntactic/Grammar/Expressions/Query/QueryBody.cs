namespace NutaParser.Syntactic.Grammar
{
	public class QueryBody : ParseMany
	{
		public static readonly QueryBody S = new QueryBody();

		public QueryBody()
			: base(
				new ParseAll(
					QueryBodyClauses.O,
					SelectOrGroupClause.S),
				new ParseAll(
					IntoTerminal.S,
					IdentifierTerminal.S))
		{
		}
	}
}
