using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class EqualsTerminal : TextTerminal
	{
		public static readonly EqualsTerminal S = new EqualsTerminal();

		public EqualsTerminal()
			: base("equals")
		{
		}
	}
}
