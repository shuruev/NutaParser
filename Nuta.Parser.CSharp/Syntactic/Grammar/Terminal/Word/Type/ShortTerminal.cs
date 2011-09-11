using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ShortTerminal : TextTerminal
	{
		public static readonly ShortTerminal S = new ShortTerminal();

		public ShortTerminal()
			: base("short")
		{
		}
	}
}
