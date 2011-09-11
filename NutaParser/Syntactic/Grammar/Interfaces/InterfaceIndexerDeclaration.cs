using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class InterfaceIndexerDeclaration : ParseAll
	{
		public static readonly InterfaceIndexerDeclaration S = new InterfaceIndexerDeclaration();

		public InterfaceIndexerDeclaration()
			: base(
				Attributes.O,
				NewTerminal.O,
				Type.S,
				ThisTerminal.S,
				LeftSquareBracketTerminal.S,
				FormalParameterList.S,
				RightSquareBracketTerminal.S,
				LeftCurlyBracketTerminal.S,
				InterfaceAccessors.S,
				RightCurlyBracketTerminal.S)
		{
		}
	}
}
