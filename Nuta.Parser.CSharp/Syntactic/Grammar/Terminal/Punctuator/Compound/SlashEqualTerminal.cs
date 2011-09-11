using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
