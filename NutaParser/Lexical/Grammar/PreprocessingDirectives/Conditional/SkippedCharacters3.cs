namespace NutaParser.Lexical.Grammar
{
	public class SkippedCharacters3 : LexicalItem
	{
		public static readonly SkippedCharacters3 S = new SkippedCharacters3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NotNumberSign.S);
		}
	}
}
