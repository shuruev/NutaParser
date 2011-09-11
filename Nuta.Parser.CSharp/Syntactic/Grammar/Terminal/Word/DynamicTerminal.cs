using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DynamicTerminal : TextTerminal
	{
		public static readonly DynamicTerminal S = new DynamicTerminal();

		public DynamicTerminal()
			: base("dynamic")
		{
		}
	}
}
