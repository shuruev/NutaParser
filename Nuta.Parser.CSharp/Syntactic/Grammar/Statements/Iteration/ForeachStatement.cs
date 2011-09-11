using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ForeachStatement : ParseAll
	{
		public static readonly ForeachStatement S = new ForeachStatement();

		public ForeachStatement()
			: base(
				ForeachTerminal.S,
				LeftRoundBracketTerminal.S,
				LocalVariableType.S,
				IdentifierTerminal.S,
				InTerminal.S,
				Expression.S,
				RightRoundBracketTerminal.S,
				EmbeddedStatement.S)
		{
		}
	}
}
