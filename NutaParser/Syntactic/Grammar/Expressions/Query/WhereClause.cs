using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class WhereClause : ParseAll
	{
		public static readonly WhereClause S = new WhereClause();

		public WhereClause()
			: base(
				WhereTerminal.S,
				BooleanExpression.S)
		{
		}
	}
}
