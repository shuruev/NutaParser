using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class InterfaceDeclaration : ParseAll
	{
		public static readonly InterfaceDeclaration S = new InterfaceDeclaration();

		public InterfaceDeclaration()
			: base(
				Attributes.O,
				InterfaceModifiers.O,
				PartialTerminal.O,
				InterfaceTerminal.S,
				IdentifierTerminal.S,
				VariantTypeParameterList.O,
				InterfaceBase.O,
				TypeParameterConstraintsClauses.O,
				InterfaceBody.S,
				SemicolonTerminal.O)
		{
		}
	}
}
