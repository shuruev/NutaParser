using Nuta.Parser.Syntactic;

namespace Nuta.Parser.CSharp.Syntactic
{
	public class NumericType : ParseAny
	{
		public static readonly NumericType S = new NumericType();

		public NumericType()
			: base(
				IntegralType.S,
				FloatingPointType.S,
				DecimalTerminal.S)
		{
		}
	}
}
