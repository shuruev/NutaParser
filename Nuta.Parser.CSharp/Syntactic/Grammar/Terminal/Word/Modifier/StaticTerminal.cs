using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class StaticTerminal : TextTerminal
	{
		public static readonly StaticTerminal S = new StaticTerminal();

		public StaticTerminal()
			: base("static")
		{
		}
	}
}
