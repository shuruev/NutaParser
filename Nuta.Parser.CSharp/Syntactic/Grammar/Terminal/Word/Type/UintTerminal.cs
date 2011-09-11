using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class UintTerminal : TextTerminal
	{
		public static readonly UintTerminal S = new UintTerminal();

		public UintTerminal()
			: base("uint")
		{
		}
	}
}
