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
				SharpTerminal.S,
				EndRegionTerminal.S,
				PpMessage.S);
		}
	}
}
