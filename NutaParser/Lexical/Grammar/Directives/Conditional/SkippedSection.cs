using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class SkippedSection : ParseMany
	{
		public static readonly SkippedSection S = new SkippedSection();

		public SkippedSection()
			: base(SkippedSectionPart.S)
		{
		}
	}
}
