namespace NutaParser.Syntactic.Grammar
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
