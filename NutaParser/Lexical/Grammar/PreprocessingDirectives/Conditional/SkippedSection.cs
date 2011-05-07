namespace NutaParser.Lexical.Grammar
{
	public class SkippedSection : LexicalItem
	{
		public static readonly SkippedSection S = new SkippedSection();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, SkippedSectionPart.S);
		}
	}
}
