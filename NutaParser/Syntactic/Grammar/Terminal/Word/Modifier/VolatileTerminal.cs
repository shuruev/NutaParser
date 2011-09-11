using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
