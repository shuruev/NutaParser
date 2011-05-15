namespace NutaParser.Lexical.Grammar
{
	public class PpEndRegion2 : LexicalItem
	{
		public static readonly PpEndRegion2 S = new PpEndRegion2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				EndRegionTerminal.S,
				PpMessage.S);
		}
	}
}
