using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OrderingDirection : ParseAny
	{
		public static readonly OrderingDirection S = new OrderingDirection();
		public static readonly Optional O = new Optional(S);

		public OrderingDirection()
			: base(
				AscendingTerminal.S,
				DescendingTerminal.S)
		{
		}
	}
}
