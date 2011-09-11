using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class UlongTerminal : TextTerminal
	{
		public static readonly UlongTerminal S = new UlongTerminal();

		public UlongTerminal()
			: base("ulong")
		{
		}
	}
}
