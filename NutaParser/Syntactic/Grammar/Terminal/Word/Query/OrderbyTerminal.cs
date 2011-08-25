namespace NutaParser.Syntactic.Grammar
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
