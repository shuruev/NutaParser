using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class StructDeclaration : ParseAll
	{
		public static readonly StructDeclaration S = new StructDeclaration();

		public StructDeclaration()
			: base(
				Attributes.O,
				StructModifiers.O,
				PartialTerminal.O,
				StructTerminal.S,
				IdentifierTerminal.S,
				TypeParameterList.O,
				StructInterfaces.O,
				TypeParameterConstraintsClauses.O,
				StructBody.S,
				SemicolonTerminal.O)
		{
		}
	}
}
