using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NamespaceTerminal : TextTerminal
	{
		public static readonly NamespaceTerminal S = new NamespaceTerminal();

		public NamespaceTerminal()
			: base("namespace")
		{
		}
	}
}
