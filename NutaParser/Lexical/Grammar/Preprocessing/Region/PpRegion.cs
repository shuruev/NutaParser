namespace NutaParser.Lexical.Grammar
{
	public class PpRegion : LexicalItem
	{
		public static readonly PpRegion S = new PpRegion();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpRegion1.S,
				PpRegion2.S);
		}
	}
}
