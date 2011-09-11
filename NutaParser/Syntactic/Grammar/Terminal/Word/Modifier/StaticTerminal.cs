using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
