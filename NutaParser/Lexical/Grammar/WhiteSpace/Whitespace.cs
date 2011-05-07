namespace NutaParser.Lexical.Grammar
{
	public class Whitespace : LexicalItem
	{
		public static readonly Whitespace S = new Whitespace();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, WhitespaceCharacter.S);
		}
	}
}
