using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class WhileStatement : ParseAll
	{
		public static readonly WhileStatement S = new WhileStatement();

		public WhileStatement()
			: base(
				WhileTerminal.S,
				LeftRoundBracketTerminal.S,
				BooleanExpression.S,
				RightRoundBracketTerminal.S,
				EmbeddedStatement.S)
		{
		}
	}
}
