namespace NutaParser.Lexical.Grammar
{
	public class RightShiftAssignment : LexicalItem
	{
		public static readonly RightShiftAssignment S = new RightShiftAssignment();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, ">>=");
		}
	}
}
