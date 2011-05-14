namespace NutaParser.Lexical.Grammar
{
	public class EndRegionTerminal : LexicalItem
	{
		public static readonly EndRegionTerminal S = new EndRegionTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "endregion");
		}
	}
}
