namespace NutaParser.Lexical.Grammar
{
	public class DecimalDigitCharacter : LexicalItem
	{
		public static readonly DecimalDigitCharacter S = new DecimalDigitCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				DecimalDigitCharacter1.S,
				DecimalDigitCharacter2.S);
		}
	}
}
