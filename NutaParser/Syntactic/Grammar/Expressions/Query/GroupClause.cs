namespace NutaParser.Syntactic.Grammar
{
	public class GroupClause : ParseAll
	{
		public static readonly GroupClause S = new GroupClause();

		public GroupClause()
			: base(
				GroupTerminal.S,
				Expression.S,
				ByTerminal.S,
				Expression.S)
		{
		}
	}
}
