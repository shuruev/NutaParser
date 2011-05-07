namespace NutaParser.Lexical.Grammar
{
	public class HexDigits : LexicalItem
	{
		public static readonly HexDigits S = new HexDigits();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, HexDigit.S);
		}
	}
}
