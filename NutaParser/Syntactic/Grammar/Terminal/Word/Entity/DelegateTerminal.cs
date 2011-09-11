using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class DelegateTerminal : TextTerminal
	{
		public static readonly DelegateTerminal S = new DelegateTerminal();

		public DelegateTerminal()
			: base("delegate")
		{
		}
	}
}
