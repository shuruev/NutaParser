using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
