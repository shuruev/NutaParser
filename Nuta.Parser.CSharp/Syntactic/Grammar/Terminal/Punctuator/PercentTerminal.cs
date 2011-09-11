using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PercentTerminal : TextTerminal
	{
		public static readonly PercentTerminal S = new PercentTerminal();

		public PercentTerminal()
			: base("%")
		{
		}
	}
}
