using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class BinaryOperatorDeclarator : ParseAll
	{
		public static readonly BinaryOperatorDeclarator S = new BinaryOperatorDeclarator();

		public BinaryOperatorDeclarator()
			: base(
				Type.S,
				OperatorTerminal.S,
				OverloadableBinaryOperator.S,
				LeftRoundBracketTerminal.S,
				Type.S,
				IdentifierTerminal.S,
				CommaTerminal.S,
				Type.S,
				IdentifierTerminal.S,
				RightRoundBracketTerminal.S)
		{
		}
	}
}
