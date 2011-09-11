using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DoubleColonTerminal : TextTerminal
	{
		public static readonly DoubleColonTerminal S = new DoubleColonTerminal();

		public DoubleColonTerminal()
			: base("::")
		{
		}
	}
}
