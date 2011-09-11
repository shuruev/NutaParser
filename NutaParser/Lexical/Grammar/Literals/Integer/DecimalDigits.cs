using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class DecimalDigits : ParseMany
	{
		public static readonly DecimalDigits S = new DecimalDigits();

		public DecimalDigits()
			: base(DecimalDigit.S)
		{
		}
	}
}
