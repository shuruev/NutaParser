using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
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
