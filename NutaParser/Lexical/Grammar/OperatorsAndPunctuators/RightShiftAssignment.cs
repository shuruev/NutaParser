namespace NutaParser.Lexical.Grammar
{
	public class RightShift : LexicalItem
	{
		public static readonly RightShift S = new RightShift();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, ">>");
		}
	}
}
