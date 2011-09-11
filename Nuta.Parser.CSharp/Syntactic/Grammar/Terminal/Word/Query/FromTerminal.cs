using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class FromTerminal : TextTerminal
	{
		public static readonly FromTerminal S = new FromTerminal();

		public FromTerminal()
			: base("from")
		{
		}
	}
}
