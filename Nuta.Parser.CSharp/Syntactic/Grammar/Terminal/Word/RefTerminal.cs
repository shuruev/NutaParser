using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class RefTerminal : TextTerminal
	{
		public static readonly RefTerminal S = new RefTerminal();

		public RefTerminal()
			: base("ref")
		{
		}
	}
}
