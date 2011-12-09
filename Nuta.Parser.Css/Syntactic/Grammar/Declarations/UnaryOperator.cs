using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class UnaryOperator : ParseAny
	{
		public static readonly UnaryOperator S = new UnaryOperator();
		public static readonly Optional O = new Optional(S);

		public UnaryOperator()
			: base(
				MinusTerminal.S,
				PlusTerminal.S)
		{
		}
	}
}
