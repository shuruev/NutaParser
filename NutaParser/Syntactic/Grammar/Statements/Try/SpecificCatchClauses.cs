using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SpecificCatchClauses : ParseMany
	{
		public static readonly SpecificCatchClauses S = new SpecificCatchClauses();

		public SpecificCatchClauses()
			: base(SpecificCatchClause.S)
		{
		}
	}
}
