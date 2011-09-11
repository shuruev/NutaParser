using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InternalTerminal : TextTerminal
	{
		public static readonly InternalTerminal S = new InternalTerminal();

		public InternalTerminal()
			: base("internal")
		{
		}
	}
}
