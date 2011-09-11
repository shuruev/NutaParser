using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ClassDeclaration : ParseAll
	{
		public static readonly ClassDeclaration S = new ClassDeclaration();

		public ClassDeclaration()
			: base(
				Attributes.O,
				ClassModifiers.O,
				PartialTerminal.O,
				ClassTerminal.S,
				IdentifierTerminal.S,
				TypeParameterList.O,
				ClassBase.O,
				TypeParameterConstraintsClauses.O,
				ClassBody.S,
				SemicolonTerminal.O)
		{
		}
	}
}
