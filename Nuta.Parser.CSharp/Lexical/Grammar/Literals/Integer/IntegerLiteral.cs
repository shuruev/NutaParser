using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class IntegerLiteral : ParseAny
	{
		public static readonly IntegerLiteral S = new IntegerLiteral();

		public IntegerLiteral()
			: base(
				HexadecimalIntegerLiteral.S,
				DecimalIntegerLiteral.S)
		{
		}
	}
}
