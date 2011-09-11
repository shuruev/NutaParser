using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
