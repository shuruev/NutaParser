using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class OnTerminal : TextTerminal
	{
		public static readonly OnTerminal S = new OnTerminal();

		public OnTerminal()
			: base("on")
		{
		}
	}
}
