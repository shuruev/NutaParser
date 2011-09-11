using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class SealedTerminal : TextTerminal
	{
		public static readonly SealedTerminal S = new SealedTerminal();

		public SealedTerminal()
			: base("sealed")
		{
		}
	}
}
