using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class InTerminal : TextTerminal
	{
		public static readonly InTerminal S = new InTerminal();

		public InTerminal()
			: base("in")
		{
		}
	}
}
