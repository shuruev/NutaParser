namespace NutaParser.Lexical.Grammar
{
	public class RegularStringLiteralCharacter : LexicalItem
	{
		public static readonly RegularStringLiteralCharacter S = new RegularStringLiteralCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				UnicodeEscapeSequence.S,
				HexadecimalEscapeSequence.S,
				SimpleEscapeSequence.S,
				SingleRegularStringLiteralCharacter.S);
		}
	}
}
