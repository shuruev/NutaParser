using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DecimalTerminal : TextTerminal
	{
		public static readonly DecimalTerminal S = new DecimalTerminal();

		public DecimalTerminal()
			: base("decimal")
		{
		}
	}
}
