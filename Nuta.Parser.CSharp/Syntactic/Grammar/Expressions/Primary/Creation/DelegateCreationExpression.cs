using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DelegateCreationExpression : ParseAll
	{
		public static readonly DelegateCreationExpression S = new DelegateCreationExpression();

		public DelegateCreationExpression()
			: base(
				NewTerminal.S,
				DelegateType.S,
				LeftRoundBracketTerminal.S,
				Expression.S,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
