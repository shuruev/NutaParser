using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class TryTerminal : TextTerminal
	{
		public static readonly TryTerminal S = new TryTerminal();

		public TryTerminal()
			: base("try")
		{
		}
	}
}
