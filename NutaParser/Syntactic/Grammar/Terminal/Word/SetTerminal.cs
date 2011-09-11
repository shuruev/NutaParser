using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class SetTerminal : TextTerminal
	{
		public static readonly SetTerminal S = new SetTerminal();

		public SetTerminal()
			: base("set")
		{
		}
	}
}
