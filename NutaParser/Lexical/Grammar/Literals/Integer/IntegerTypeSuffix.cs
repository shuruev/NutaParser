namespace NutaParser.Lexical.Grammar
{
	public class IntegerTypeSuffix : LexicalItem
	{
		public static readonly IntegerTypeSuffix S = new IntegerTypeSuffix();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(
				state,
				"UL",
				"Ul",
				"uL",
				"ul",
				"LU",
				"Lu",
				"lU",
				"lu",
				"U",
				"u",
				"L",
				"l");
		}
	}
}
