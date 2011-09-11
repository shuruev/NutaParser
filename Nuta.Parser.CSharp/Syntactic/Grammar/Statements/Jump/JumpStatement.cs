using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class JumpStatement : ParseAny
	{
		public static readonly JumpStatement S = new JumpStatement();

		public JumpStatement()
			: base(
				BreakStatement.S,
				ContinueStatement.S,
				GotoStatement.S,
				ReturnStatement.S,
				ThrowStatement.S)
		{
		}
	}
}
