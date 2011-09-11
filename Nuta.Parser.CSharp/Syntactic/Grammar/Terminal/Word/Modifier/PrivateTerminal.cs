using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class PrivateTerminal : TextTerminal
	{
		public static readonly PrivateTerminal S = new PrivateTerminal();

		public PrivateTerminal()
			: base("private")
		{
		}
	}
}
