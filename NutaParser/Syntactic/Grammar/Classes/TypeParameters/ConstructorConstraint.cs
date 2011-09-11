using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
