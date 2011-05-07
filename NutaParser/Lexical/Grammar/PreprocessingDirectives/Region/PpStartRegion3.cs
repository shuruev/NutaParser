namespace NutaParser.Lexical.Grammar
{
	public class PpStartRegion3 : LexicalItem
	{
		public static readonly PpStartRegion3 S = new PpStartRegion3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SharpTerminal.S,
				Whitespace.S,
				RegionTerminal.S,
				PpMessage.S);
		}
	}
}
