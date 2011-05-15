namespace NutaParser.Lexical.Grammar
{
	public class PpStartRegion4 : LexicalItem
	{
		public static readonly PpStartRegion4 S = new PpStartRegion4();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				RegionTerminal.S,
				PpMessage.S);
		}
	}
}
