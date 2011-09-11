using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
