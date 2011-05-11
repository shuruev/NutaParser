namespace NutaParser.Lexical.Grammar
{
	public class EndifTerminal : LexicalItem
	{
		public static readonly EndifTerminal S = new EndifTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "endif");
		}
	}
}
