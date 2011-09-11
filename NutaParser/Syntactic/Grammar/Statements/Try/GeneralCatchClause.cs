using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
