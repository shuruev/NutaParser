using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class EqualsTerminal : TextTerminal
	{
		public static readonly EqualsTerminal S = new EqualsTerminal();

		public EqualsTerminal()
			: base("equals")
		{
		}
	}
}
