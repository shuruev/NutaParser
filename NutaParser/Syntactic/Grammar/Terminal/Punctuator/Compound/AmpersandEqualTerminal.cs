using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class AmpersandEqualTerminal : TextTerminal
	{
		public static readonly AmpersandEqualTerminal S = new AmpersandEqualTerminal();

		public AmpersandEqualTerminal()
			: base("&=")
		{
		}
	}
}
