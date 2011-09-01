namespace NutaParser.Syntactic.Grammar
{
	public class UsingNamespaceDirective : ParseAll
	{
		public static readonly UsingNamespaceDirective S = new UsingNamespaceDirective();

		public UsingNamespaceDirective()
			: base(
				UsingTerminal.S,
				NamespaceName.S,
				SemicolonTerminal.S)
		{
		}
	}
}
