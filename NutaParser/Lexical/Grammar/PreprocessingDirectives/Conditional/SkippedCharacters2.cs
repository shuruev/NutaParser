namespace NutaParser.Lexical.Grammar
{
	public class SkippedCharacters2 : LexicalItem
	{
		public static readonly SkippedCharacters2 S = new SkippedCharacters2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NotNumberSign.S,
				InputCharacters.S);
		}
	}
}
