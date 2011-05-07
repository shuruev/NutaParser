namespace NutaParser.Lexical.Grammar
{
	public class PpEndRegion : LexicalItem
	{
		public static readonly PpEndRegion S = new PpEndRegion();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpEndRegion1.S,
				PpEndRegion2.S,
				PpEndRegion3.S,
				PpEndRegion4.S);
		}
	}
}
