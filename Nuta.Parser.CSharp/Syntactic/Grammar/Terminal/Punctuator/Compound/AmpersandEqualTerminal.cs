using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
