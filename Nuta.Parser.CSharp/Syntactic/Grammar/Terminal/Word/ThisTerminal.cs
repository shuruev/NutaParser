using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ThisTerminal : TextTerminal
	{
		public static readonly ThisTerminal S = new ThisTerminal();

		public ThisTerminal()
			: base("this")
		{
		}
	}
}
