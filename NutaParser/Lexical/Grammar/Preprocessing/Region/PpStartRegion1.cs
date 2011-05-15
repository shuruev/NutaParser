namespace NutaParser.Lexical.Grammar
{
	public class PpStartRegion1 : LexicalItem
	{
		public static readonly PpStartRegion1 S = new PpStartRegion1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				Whitespace.S,
				RegionTerminal.S,
				PpMessage.S);
		}
	}
}
