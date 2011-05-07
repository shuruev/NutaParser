namespace NutaParser.Lexical.Grammar
{
	public class PpRegion2 : LexicalItem
	{
		public static readonly PpRegion2 S = new PpRegion2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				PpStartRegion.S,
				PpEndRegion.S);
		}
	}
}
