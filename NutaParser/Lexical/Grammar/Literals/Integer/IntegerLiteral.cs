using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
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
