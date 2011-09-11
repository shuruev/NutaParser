using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class CheckedTerminal : TextTerminal
	{
		public static readonly CheckedTerminal S = new CheckedTerminal();

		public CheckedTerminal()
			: base("checked")
		{
		}
	}
}
