using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class OverrideTerminal : TextTerminal
	{
		public static readonly OverrideTerminal S = new OverrideTerminal();

		public OverrideTerminal()
			: base("override")
		{
		}
	}
}
