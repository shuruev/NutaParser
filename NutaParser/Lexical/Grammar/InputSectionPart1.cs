namespace NutaParser.Lexical.Grammar
{
	public class InputSectionPart1 : LexicalItem
	{
		public static readonly InputSectionPart1 S = new InputSectionPart1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				InputElements.S,
				NewLine.S);
		}
	}
}
