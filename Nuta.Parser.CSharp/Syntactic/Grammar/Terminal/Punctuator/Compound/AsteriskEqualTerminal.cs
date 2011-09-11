using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AsteriskEqualTerminal : TextTerminal
	{
		public static readonly AsteriskEqualTerminal S = new AsteriskEqualTerminal();

		public AsteriskEqualTerminal()
			: base("*=")
		{
		}
	}
}
