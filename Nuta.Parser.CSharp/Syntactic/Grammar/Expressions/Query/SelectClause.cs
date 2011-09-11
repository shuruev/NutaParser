using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
