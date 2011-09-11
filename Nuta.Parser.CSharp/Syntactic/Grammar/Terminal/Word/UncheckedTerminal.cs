using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class UncheckedTerminal : TextTerminal
	{
		public static readonly UncheckedTerminal S = new UncheckedTerminal();

		public UncheckedTerminal()
			: base("unchecked")
		{
		}
	}
}
