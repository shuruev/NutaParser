using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class RemoveTerminal : TextTerminal
	{
		public static readonly RemoveTerminal S = new RemoveTerminal();

		public RemoveTerminal()
			: base("remove")
		{
		}
	}
}
