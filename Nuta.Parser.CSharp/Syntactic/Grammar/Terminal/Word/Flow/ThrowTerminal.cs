using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ThrowTerminal : TextTerminal
	{
		public static readonly ThrowTerminal S = new ThrowTerminal();

		public ThrowTerminal()
			: base("throw")
		{
		}
	}
}
