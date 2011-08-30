namespace NutaParser.Syntactic.Grammar
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
