using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class UshortTerminal : TextTerminal
	{
		public static readonly UshortTerminal S = new UshortTerminal();

		public UshortTerminal()
			: base("ushort")
		{
		}
	}
}
