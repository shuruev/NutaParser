using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class Block : SyntacticItem
	{
		public static readonly Block S = new Block();

		public override bool Parse(SyntacticState state)
		{
			return ParseAll(
				state,
				LeftCurlyBracketTerminal.S,
				StatementList.O,
				RightCurlyBracketTerminal.S);
		}
	}
}
