using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
