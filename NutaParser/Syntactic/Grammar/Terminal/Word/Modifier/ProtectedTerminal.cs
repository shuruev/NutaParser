using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ProtectedTerminal : TextTerminal
	{
		public static readonly ProtectedTerminal S = new ProtectedTerminal();

		public ProtectedTerminal()
			: base("protected")
		{
		}
	}
}
