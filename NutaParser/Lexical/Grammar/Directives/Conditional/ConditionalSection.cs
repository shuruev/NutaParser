namespace NutaParser.Lexical.Grammar
{
	public class ConditionalSection : ParseAny
	{
		public static readonly ConditionalSection S = new ConditionalSection();
		public static readonly Optional O = new Optional(S);

		public ConditionalSection()
			: base(
				InputSection.S,
				SkippedSection.S)
		{
		}
	}
}
