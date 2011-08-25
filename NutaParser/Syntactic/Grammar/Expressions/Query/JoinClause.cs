namespace NutaParser.Syntactic.Grammar
{
	public class JoinClause : ParseAll
	{
		public static readonly JoinClause S = new JoinClause();

		public JoinClause()
			: base(
				JoinTerminal.S,
				new ParseAny(
					new ParseAll(Type.S, IdentifierTerminal.S, InTerminal.S),
					new ParseAll(IdentifierTerminal.S, InTerminal.S)),
				Expression.S,
				OnTerminal.S,
				Expression.S,
				EqualsTerminal.S,
				Expression.S)
		{
		}
	}
}
