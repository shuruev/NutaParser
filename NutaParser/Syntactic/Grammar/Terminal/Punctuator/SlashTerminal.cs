using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SlashTerminal : TextTerminal
	{
		public static readonly SlashTerminal S = new SlashTerminal();

		public SlashTerminal()
			: base("/")
		{
		}
	}
}
