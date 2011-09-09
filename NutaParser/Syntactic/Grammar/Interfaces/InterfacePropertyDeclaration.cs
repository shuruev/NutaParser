namespace NutaParser.Syntactic.Grammar
{
	public class InterfacePropertyDeclaration : ParseAll
	{
		public static readonly InterfacePropertyDeclaration S = new InterfacePropertyDeclaration();

		public InterfacePropertyDeclaration()
			: base(
				Attributes.O,
				NewTerminal.O,
				Type.S,
				IdentifierTerminal.S,
				LeftCurlyBracketTerminal.S,
				InterfaceAccessors.S,
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
