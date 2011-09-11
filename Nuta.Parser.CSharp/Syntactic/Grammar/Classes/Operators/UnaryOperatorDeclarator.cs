using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class UnaryOperatorDeclarator : ParseAll
	{
		public static readonly UnaryOperatorDeclarator S = new UnaryOperatorDeclarator();

		public UnaryOperatorDeclarator()
			: base(
				Type.S,
				OperatorTerminal.S,
				OverloadableUnaryOperator.S,
				LeftRoundBracketTerminal.S,
				Type.S,
				IdentifierTerminal.S,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
