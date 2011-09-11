using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class NotEqualTerminal : TextTerminal
	{
		public static readonly NotEqualTerminal S = new NotEqualTerminal();

		public NotEqualTerminal()
			: base("!=")
		{
		}
	}
}
