namespace NutaParser.Lexical.Grammar
{
	public class DecimalDigits : LexicalItem
	{
		public static readonly DecimalDigits S = new DecimalDigits();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, DecimalDigit.S);
		}
	}
}
