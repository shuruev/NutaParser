namespace NutaParser.Lexical.Grammar
{
	public class PpEndRegion3 : LexicalItem
	{
		public static readonly PpEndRegion3 S = new PpEndRegion3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				Whitespace.S,
				EndRegionTerminal.S,
				PpMessage.S);
		}
	}
}
