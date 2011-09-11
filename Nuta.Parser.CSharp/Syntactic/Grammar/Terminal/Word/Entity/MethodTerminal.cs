using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class MethodTerminal : TextTerminal
	{
		public static readonly MethodTerminal S = new MethodTerminal();

		public MethodTerminal()
			: base("method")
		{
		}
	}
}
