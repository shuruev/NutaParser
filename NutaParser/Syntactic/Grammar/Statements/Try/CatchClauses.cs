namespace NutaParser.Syntactic.Grammar
{
	public class CatchClauses : ParseAny
	{
		public static readonly CatchClauses S = new CatchClauses();

		public CatchClauses()
			: base(
				new ParseAll(SpecificCatchClauses.S, GeneralCatchClause.S),
				SpecificCatchClauses.S,
				GeneralCatchClause.S)
		{
		}
	}
}
