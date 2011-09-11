using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ConstructorConstraint : ParseAll
	{
		public static readonly ConstructorConstraint S = new ConstructorConstraint();

		public ConstructorConstraint()
			: base(
				NewTerminal.S,
				LeftRoundBracketTerminal.S,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
