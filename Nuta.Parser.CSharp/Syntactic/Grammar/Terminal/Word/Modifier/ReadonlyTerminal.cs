using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ReadonlyTerminal : TextTerminal
	{
		public static readonly ReadonlyTerminal S = new ReadonlyTerminal();

		public ReadonlyTerminal()
			: base("readonly")
		{
		}
	}
}
