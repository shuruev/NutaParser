namespace NutaParser.Lexical.Grammar
{
	public class FormattingCharacter : LexicalItem
	{
		public static readonly FormattingCharacter S = new FormattingCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				FormattingCharacter1.S,
				FormattingCharacter2.S);
		}
	}
}
