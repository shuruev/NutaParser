namespace NutaParser.Lexical.Grammar
{
	public class PpEndRegion1 : LexicalItem
	{
		public static readonly PpEndRegion1 S = new PpEndRegion1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				SharpTerminal.S,
				Whitespace.S,
				EndRegionTerminal.S,
				PpMessage.S);
		}
	}
}
