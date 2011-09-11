using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SpecificCatchClause : ParseAll
	{
		public static readonly SpecificCatchClause S = new SpecificCatchClause();

		public SpecificCatchClause()
			: base(
				CatchTerminal.S,
				LeftRoundBracketTerminal.S,
				ClassType.S,
				IdentifierTerminal.O,
				RightRoundBracketTerminal.S,
				Block.S)
		{
		}
	}
}
