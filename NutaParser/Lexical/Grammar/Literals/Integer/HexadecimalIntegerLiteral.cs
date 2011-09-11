using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class HexadecimalIntegerLiteral : ParseAll
	{
		public static readonly HexadecimalIntegerLiteral S = new HexadecimalIntegerLiteral();

		public HexadecimalIntegerLiteral()
			: base(
				new SingleCharacterTerminal('0'),
				new SingleCharacterTerminal('x', 'X'),
				HexDigits.S,
				IntegerTypeSuffix.O)
		{
		}
	}
}
