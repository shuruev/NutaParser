using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class YieldTerminal : TextTerminal
	{
		public static readonly YieldTerminal S = new YieldTerminal();

		public YieldTerminal()
			: base("yield")
		{
		}
	}
}
