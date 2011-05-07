namespace NutaParser.Lexical.Grammar
{
	public class InputSectionPart : LexicalItem
	{
		public static readonly InputSectionPart S = new InputSectionPart();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpDirective.S,
				InputSectionPart1.S,
				NewLine.S);
		}
	}
}
