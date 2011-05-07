namespace NutaParser.Lexical.Grammar
{
	public class IdentifierOrKeyword : LexicalItem
	{
		public static readonly IdentifierOrKeyword S = new IdentifierOrKeyword();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				IdentifierOrKeyword1.S,
				IdentifierStartCharacter.S);
		}
	}
}
