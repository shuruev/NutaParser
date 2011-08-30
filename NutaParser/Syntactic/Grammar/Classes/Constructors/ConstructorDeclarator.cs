namespace NutaParser.Syntactic.Grammar
{
	public class ConstructorDeclarator : ParseAll
	{
		public static readonly ConstructorDeclarator S = new ConstructorDeclarator();

		public ConstructorDeclarator()
			: base(
				IdentifierTerminal.S,
				LeftRoundBracketTerminal.S,
				FormalParameterList.O,
				RightRoundBracketTerminal.S,
				ConstructorInitializer.O)
		{
		}
	}
}
