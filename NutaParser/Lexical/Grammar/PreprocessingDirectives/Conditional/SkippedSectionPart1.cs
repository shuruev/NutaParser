namespace NutaParser.Lexical.Grammar
{
	public class SkippedSectionPart1 : LexicalItem
	{
		public static readonly SkippedSectionPart1 S = new SkippedSectionPart1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SkippedCharacters.S,
				NewLine.S);
		}
	}
}
