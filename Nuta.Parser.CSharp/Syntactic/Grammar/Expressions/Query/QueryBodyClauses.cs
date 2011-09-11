using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class QueryBodyClauses : ParseMany
	{
		public static readonly QueryBodyClauses S = new QueryBodyClauses();
		public static readonly Optional O = new Optional(S);

		public QueryBodyClauses()
			: base(QueryBodyClause.S)
		{
		}
	}
}
