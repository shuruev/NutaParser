namespace NutaParser.Lexical.Grammar
{
	public class PpNewLine : LexicalItem
	{
		public static readonly PpNewLine S = new PpNewLine();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpNewLine1.S,
				PpNewLine2.S,
				PpNewLine3.S,
				NewLine.S);
		}
	}
}
