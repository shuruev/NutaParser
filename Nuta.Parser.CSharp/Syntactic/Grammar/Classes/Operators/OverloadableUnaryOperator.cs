using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class OverloadableUnaryOperator : ParseAny
	{
		public static readonly OverloadableUnaryOperator S = new OverloadableUnaryOperator();

		public OverloadableUnaryOperator()
			: base(
				TrueTerminal.S,
				FalseTerminal.S,
				DoublePlusTerminal.S,
				DoubleMinusTerminal.S,
				PlusTerminal.S,
				MinusTerminal.S,
				ExclamationTerminal.S,
				TildeTerminal.S)
		{
		}
	}
}
