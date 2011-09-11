using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class RealLiteral : ParseAny
	{
		public static readonly RealLiteral S = new RealLiteral();

		public RealLiteral()
			: base(
				new ParseAll(DecimalDigits.S, PeriodTerminal.S, DecimalDigits.S, ExponentPart.O, RealTypeSuffix.O),
				new ParseAll(PeriodTerminal.S, DecimalDigits.S, ExponentPart.O, RealTypeSuffix.O),
				new ParseAll(DecimalDigits.S, ExponentPart.S, RealTypeSuffix.O),
				new ParseAll(DecimalDigits.S, RealTypeSuffix.S))
		{
		}
	}
}
