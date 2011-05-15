namespace NutaParser.Lexical.Grammar
{
	public class HexDigits : ParseMany
	{
		public static readonly HexDigits S = new HexDigits();

		public HexDigits()
			: base(HexDigit.S)
		{
		}
	}
}
