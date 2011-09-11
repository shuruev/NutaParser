using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class IntTerminal : TextTerminal
	{
		public static readonly IntTerminal S = new IntTerminal();

		public IntTerminal()
			: base("int")
		{
		}
	}
}
