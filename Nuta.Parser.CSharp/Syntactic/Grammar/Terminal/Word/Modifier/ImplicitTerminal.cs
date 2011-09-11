using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ImplicitTerminal : TextTerminal
	{
		public static readonly ImplicitTerminal S = new ImplicitTerminal();

		public ImplicitTerminal()
			: base("implicit")
		{
		}
	}
}
