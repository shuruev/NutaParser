using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ForeachTerminal : TextTerminal
	{
		public static readonly ForeachTerminal S = new ForeachTerminal();

		public ForeachTerminal()
			: base("foreach")
		{
		}
	}
}
