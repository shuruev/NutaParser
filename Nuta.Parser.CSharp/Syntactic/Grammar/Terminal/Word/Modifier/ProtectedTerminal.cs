using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ProtectedTerminal : TextTerminal
	{
		public static readonly ProtectedTerminal S = new ProtectedTerminal();

		public ProtectedTerminal()
			: base("protected")
		{
		}
	}
}
