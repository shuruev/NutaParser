using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SelectOrGroupClause : ParseAny
	{
		public static readonly SelectOrGroupClause S = new SelectOrGroupClause();

		public SelectOrGroupClause()
			: base(
				SelectClause.S,
				GroupClause.S)
		{
		}
	}
}
