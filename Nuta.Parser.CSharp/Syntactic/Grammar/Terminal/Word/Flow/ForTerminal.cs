using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ForTerminal : TextTerminal
	{
		public static readonly ForTerminal S = new ForTerminal();

		public ForTerminal()
			: base("for")
		{
		}
	}
}
