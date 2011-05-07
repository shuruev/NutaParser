namespace NutaParser.Lexical.Grammar
{
	public class SkippedCharacters1 : LexicalItem
	{
		public static readonly SkippedCharacters1 S = new SkippedCharacters1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NotNumberSign.S,
				InputCharacters.S);
		}
	}
}
