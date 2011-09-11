using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NamespaceDeclaration : ParseAll
	{
		public static readonly NamespaceDeclaration S = new NamespaceDeclaration();

		public NamespaceDeclaration()
			: base(
				NamespaceTerminal.S,
				QualifiedIdentifier.S,
				NamespaceBody.S,
				SemicolonTerminal.O)
		{
		}
	}
}
