using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceEventDeclaration : ParseAll
	{
		public static readonly InterfaceEventDeclaration S = new InterfaceEventDeclaration();

		public InterfaceEventDeclaration()
			: base(
				Attributes.O,
				NewTerminal.O,
				EventTerminal.S,
				Type.S,
				IdentifierTerminal.S,
				SemicolonTerminal.S)
		{
		}
	}
}
