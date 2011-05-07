namespace NutaParser.Lexical.Grammar
{
	public class Character : LexicalItem
	{
		public static readonly Character S = new Character();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				UnicodeEscapeSequence.S,
				HexadecimalEscapeSequence.S,
				SimpleEscapeSequence.S,
				SingleCharacter.S);
		}
	}
}
