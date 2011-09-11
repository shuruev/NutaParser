using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
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
