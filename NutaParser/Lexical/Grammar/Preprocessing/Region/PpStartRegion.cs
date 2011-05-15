namespace NutaParser.Lexical.Grammar
{
	public class PpStartRegion : LexicalItem
	{
		public static readonly PpStartRegion S = new PpStartRegion();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpStartRegion1.S,
				PpStartRegion2.S,
				PpStartRegion3.S,
				PpStartRegion4.S);
		}
	}
}
