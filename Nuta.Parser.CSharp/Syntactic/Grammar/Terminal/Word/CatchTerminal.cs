using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class CatchTerminal : TextTerminal
	{
		public static readonly CatchTerminal S = new CatchTerminal();

		public CatchTerminal()
			: base("catch")
		{
		}
	}
}
