using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class VolatileTerminal : TextTerminal
	{
		public static readonly VolatileTerminal S = new VolatileTerminal();

		public VolatileTerminal()
			: base("volatile")
		{
		}
	}
}
