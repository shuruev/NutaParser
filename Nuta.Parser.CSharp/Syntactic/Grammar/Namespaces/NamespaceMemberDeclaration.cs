using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NamespaceMemberDeclaration : ParseAny
	{
		public static readonly NamespaceMemberDeclaration S = new NamespaceMemberDeclaration();

		public NamespaceMemberDeclaration()
			: base(
				TypeDeclaration.S,
				NamespaceDeclaration.S)
		{
		}
	}
}
