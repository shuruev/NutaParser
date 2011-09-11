using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StaticConstructorDeclaration : ParseAll
	{
		public static readonly StaticConstructorDeclaration S = new StaticConstructorDeclaration();

		public StaticConstructorDeclaration()
			: base(
				Attributes.O,
				StaticConstructorModifiers.S,
				IdentifierTerminal.S,
				LeftRoundBracketTerminal.S,
				RightRoundBracketTerminal.S,
				StaticConstructorBody.S)
		{
		}
	}
}
