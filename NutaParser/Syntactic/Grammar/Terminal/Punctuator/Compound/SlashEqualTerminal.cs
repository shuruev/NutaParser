using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SlashEqualTerminal : TextTerminal
	{
		public static readonly SlashEqualTerminal S = new SlashEqualTerminal();

		public SlashEqualTerminal()
			: base("/=")
		{
		}
	}
}
