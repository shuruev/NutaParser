namespace NutaParser.Syntactic.Grammar
{
	public class JoinIntoClause : ParseAll
	{
		public static readonly JoinIntoClause S = new JoinIntoClause();

		public JoinIntoClause()
			: base(
				JoinTerminal.S,
				new ParseAny(
					new ParseAll(Type.S, IdentifierTerminal.S, InTerminal.S),
					new ParseAll(IdentifierTerminal.S, InTerminal.S)),
				Expression.S,
				OnTerminal.S,
				Expression.S,
				EqualsTerminal.S,
				Expression.S,
				IntoTerminal.S,
				IdentifierTerminal.S)
		{
		}
	}
}
