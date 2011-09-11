using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OrderbyTerminal : TextTerminal
	{
		public static readonly OrderbyTerminal S = new OrderbyTerminal();

		public OrderbyTerminal()
			: base("orderby")
		{
		}
	}
}
