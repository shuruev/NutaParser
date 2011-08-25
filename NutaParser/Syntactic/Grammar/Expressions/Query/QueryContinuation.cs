namespace NutaParser.Syntactic.Grammar
{
	public class QueryContinuation : SyntacticItem
	{
		public static readonly QueryContinuation S = new QueryContinuation();
		public static readonly Optional O = new Optional(S);

		public override bool Parse(SyntacticState state)
		{
			return ParseAll(
				state,
				IntoTerminal.S,
				IdentifierTerminal.S,
				QueryBody.S);
		}
	}
}
