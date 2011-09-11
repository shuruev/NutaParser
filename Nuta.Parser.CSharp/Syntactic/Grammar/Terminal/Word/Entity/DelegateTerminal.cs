using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DelegateTerminal : TextTerminal
	{
		public static readonly DelegateTerminal S = new DelegateTerminal();

		public DelegateTerminal()
			: base("delegate")
		{
		}
	}
}
