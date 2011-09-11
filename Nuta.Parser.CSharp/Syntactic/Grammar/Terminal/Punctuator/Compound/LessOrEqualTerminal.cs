using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LessOrEqualTerminal : TextTerminal
	{
		public static readonly LessOrEqualTerminal S = new LessOrEqualTerminal();

		public LessOrEqualTerminal()
			: base("<=")
		{
		}
	}
}
