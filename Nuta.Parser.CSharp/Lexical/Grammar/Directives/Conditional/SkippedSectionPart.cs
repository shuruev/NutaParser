using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class SkippedSectionPart : ParseAny
	{
		public static readonly SkippedSectionPart S = new SkippedSectionPart();

		public SkippedSectionPart()
			: base(
				PpDirective.S,
				new ParseAll(SkippedCharacters.O, NewLine.S))
		{
		}
	}
}
