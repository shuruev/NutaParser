using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class GeneralCatchClause : ParseAll
	{
		public static readonly GeneralCatchClause S = new GeneralCatchClause();

		public GeneralCatchClause()
			: base(
				CatchTerminal.S,
				Block.S)
		{
		}
	}
}
