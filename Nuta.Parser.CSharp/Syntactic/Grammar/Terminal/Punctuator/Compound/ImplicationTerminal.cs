using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ImplicationTerminal : TextTerminal
	{
		public static readonly ImplicationTerminal S = new ImplicationTerminal();

		public ImplicationTerminal()
			: base("=>")
		{
		}
	}
}
