using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class UsingTerminal : TextTerminal
	{
		public static readonly UsingTerminal S = new UsingTerminal();

		public UsingTerminal()
			: base("using")
		{
		}
	}
}
