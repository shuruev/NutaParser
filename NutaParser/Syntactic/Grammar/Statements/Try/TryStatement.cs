using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class TryStatement : ParseAll
	{
		public static readonly TryStatement S = new TryStatement();

		public TryStatement()
			: base(
				TryTerminal.S,
				Block.S,
				new ParseAny(
					new ParseAll(CatchClauses.S, FinallyClause.S),
					CatchClauses.S,
					FinallyClause.S))
		{
		}
	}
}
