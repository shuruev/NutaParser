using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class PropertyDeclaration : ParseAll
	{
		public static readonly PropertyDeclaration S = new PropertyDeclaration();

		public PropertyDeclaration()
			: base(
				Attributes.O,
				PropertyModifiers.O,
				Type.S,
				MemberName.S,
				LeftCurlyBracketTerminal.S,
				AccessorDeclarations.S,
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
