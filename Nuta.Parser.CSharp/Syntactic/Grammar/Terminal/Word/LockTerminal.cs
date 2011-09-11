using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LockTerminal : TextTerminal
	{
		public static readonly LockTerminal S = new LockTerminal();

		public LockTerminal()
			: base("lock")
		{
		}
	}
}
