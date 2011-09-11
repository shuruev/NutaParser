using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FinallyClause : ParseAll
	{
		public static readonly FinallyClause S = new FinallyClause();

		public FinallyClause()
			: base(
				FinallyTerminal.S,
				Block.S)
		{
		}
	}
}
