namespace NutaParser.Lexical.Grammar
{
	public class PpRegion1 : LexicalItem
	{
		public static readonly PpRegion1 S = new PpRegion1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				PpStartRegion.S,
				ConditionalSection.S,
				PpEndRegion.S);
		}
	}
}
