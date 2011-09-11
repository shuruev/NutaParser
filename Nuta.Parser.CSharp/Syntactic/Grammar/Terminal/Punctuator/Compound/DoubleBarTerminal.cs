using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class DoubleBarTerminal : TextTerminal
	{
		public static readonly DoubleBarTerminal S = new DoubleBarTerminal();

		public DoubleBarTerminal()
			: base("||")
		{
		}
	}
}
