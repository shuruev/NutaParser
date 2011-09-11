using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class QueryExpression : ParseAll
	{
		public static readonly QueryExpression S = new QueryExpression();

		public QueryExpression()
			: base(
				FromClause.S,
				QueryBody.S)
		{
		}
	}
}
