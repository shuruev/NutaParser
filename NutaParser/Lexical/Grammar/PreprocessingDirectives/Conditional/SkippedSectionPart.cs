namespace NutaParser.Lexical.Grammar
{
	public class SkippedSectionPart : LexicalItem
	{
		public static readonly SkippedSectionPart S = new SkippedSectionPart();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				// TODO: a question here about the order (possible recursion?)
				PpDirective.S,
				SkippedSectionPart1.S,
				NewLine.S);
		}
	}
}
