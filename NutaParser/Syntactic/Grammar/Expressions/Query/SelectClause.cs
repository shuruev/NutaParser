using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SelectClause : ParseAll
	{
		public static readonly SelectClause S = new SelectClause();

		public SelectClause()
			: base(
				SelectTerminal.S,
				Expression.S)
		{
		}
	}
}
