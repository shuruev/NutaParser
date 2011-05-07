namespace NutaParser.Lexical.Grammar
{
	public class InputSection : LexicalItem
	{
		public static readonly InputSection S = new InputSection();

		public override bool Parse(LexicalState state)
		{
			return ParseMany(state, InputSectionPart.S);
		}
	}
}
