namespace NutaParser.Lexical.Grammar
{
	public class ConditionalSection : LexicalItem
	{
		public static readonly ConditionalSection S = new ConditionalSection();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				InputSection.S,
				SkippedSection.S);
		}
	}
}
