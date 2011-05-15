namespace NutaParser.Lexical.Grammar
{
	public class PpStartRegion2 : LexicalItem
	{
		public static readonly PpStartRegion2 S = new PpStartRegion2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				RegionTerminal.S,
				PpMessage.S);
		}
	}
}
