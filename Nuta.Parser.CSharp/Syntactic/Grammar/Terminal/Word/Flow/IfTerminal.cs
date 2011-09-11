using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class IfTerminal : TextTerminal
	{
		public static readonly IfTerminal S = new IfTerminal();

		public IfTerminal()
			: base("if")
		{
		}
	}
}
