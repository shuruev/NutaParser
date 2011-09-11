using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class ConstTerminal : TextTerminal
	{
		public static readonly ConstTerminal S = new ConstTerminal();

		public ConstTerminal()
			: base("const")
		{
		}
	}
}
