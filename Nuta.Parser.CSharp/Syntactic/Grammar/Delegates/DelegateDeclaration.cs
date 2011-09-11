using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DelegateDeclaration : ParseAll
	{
		public static readonly DelegateDeclaration S = new DelegateDeclaration();

		public DelegateDeclaration()
			: base(
				Attributes.O,
				DelegateModifiers.O,
				DelegateTerminal.S,
				ReturnType.S,
				IdentifierTerminal.S,
				VariantTypeParameterList.O,
				LeftRoundBracketTerminal.S,
				FormalParameterList.O,
				RightRoundBracketTerminal.S,
				TypeParameterConstraintsClauses.O,
				SemicolonTerminal.S)
		{
		}
	}
}
