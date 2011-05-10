namespace NutaParser.Lexical.Grammar
{
	public class PpLine : LexicalItem
	{
		public static readonly PpLine S = new PpLine();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpLine1.S,
				PpLine2.S,
				PpLine3.S,
				PpLine4.S);
		}
	}
}
