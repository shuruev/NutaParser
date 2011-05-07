namespace NutaParser.Lexical.Grammar
{
	public class SkippedCharacters : LexicalItem
	{
		public static readonly SkippedCharacters S = new SkippedCharacters();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				SkippedCharacters1.S,
				SkippedCharacters2.S,
				SkippedCharacters3.S,
				NotNumberSign.S);
		}
	}
}
