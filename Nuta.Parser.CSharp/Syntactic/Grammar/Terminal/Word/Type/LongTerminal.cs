using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class LongTerminal : TextTerminal
	{
		public static readonly LongTerminal S = new LongTerminal();

		public LongTerminal()
			: base("long")
		{
		}
	}
}
