using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
