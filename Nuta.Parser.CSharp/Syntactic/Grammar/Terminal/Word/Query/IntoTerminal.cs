using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class IntoTerminal : TextTerminal
	{
		public static readonly IntoTerminal S = new IntoTerminal();

		public IntoTerminal()
			: base("into")
		{
		}
	}
}
