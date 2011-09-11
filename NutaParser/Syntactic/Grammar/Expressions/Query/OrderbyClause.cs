using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class OrderbyClause : ParseAll
	{
		public static readonly OrderbyClause S = new OrderbyClause();

		public OrderbyClause()
			: base(
				OrderbyTerminal.S,
				Orderings.S)
		{
		}
	}
}
