using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ReturnTerminal : TextTerminal
	{
		public static readonly ReturnTerminal S = new ReturnTerminal();

		public ReturnTerminal()
			: base("return")
		{
		}
	}
}
