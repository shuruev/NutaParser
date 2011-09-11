using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class AbstractTerminal : TextTerminal
	{
		public static readonly AbstractTerminal S = new AbstractTerminal();

		public AbstractTerminal()
			: base("abstract")
		{
		}
	}
}
