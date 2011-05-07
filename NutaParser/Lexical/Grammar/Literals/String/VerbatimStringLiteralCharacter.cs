namespace NutaParser.Lexical.Grammar
{
	public class VerbatimStringLiteralCharacter : LexicalItem
	{
		public static readonly VerbatimStringLiteralCharacter S = new VerbatimStringLiteralCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				SingleVerbatimStringLiteralCharacter.S,
				QuoteEscapeSequence.S);
		}
	}
}
