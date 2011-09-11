using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class InternalTerminal : TextTerminal
	{
		public static readonly InternalTerminal S = new InternalTerminal();

		public InternalTerminal()
			: base("internal")
		{
		}
	}
}
