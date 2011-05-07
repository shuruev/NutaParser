namespace NutaParser.Lexical.Grammar
{
	public class PpEndRegion4 : LexicalItem
	{
		public static readonly PpEndRegion4 S = new PpEndRegion4();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SharpTerminal.S,
				EndRegionTerminal.S,
				PpMessage.S);
		}
	}
}
