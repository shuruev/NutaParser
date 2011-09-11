using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class BaseTerminal : TextTerminal
	{
		public static readonly BaseTerminal S = new BaseTerminal();

		public BaseTerminal()
			: base("base")
		{
		}
	}
}
