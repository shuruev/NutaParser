using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InterfaceMemberDeclaration : ParseAny
	{
		public static readonly InterfaceMemberDeclaration S = new InterfaceMemberDeclaration();

		public InterfaceMemberDeclaration()
			: base(
				InterfaceMethodDeclaration.S,
				InterfacePropertyDeclaration.S,
				InterfaceEventDeclaration.S,
				InterfaceIndexerDeclaration.S)
		{
		}
	}
}
