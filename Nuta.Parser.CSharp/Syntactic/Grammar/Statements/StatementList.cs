using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StatementList : ParseMany
	{
		public static readonly StatementList S = new StatementList();
		public static readonly Optional O = new Optional(S);

		public StatementList()
			: base(Statement.S)
		{
		}
	}
}
