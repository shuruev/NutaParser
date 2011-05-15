namespace NutaParser.Lexical.Grammar
{
	public class PpNewLine3 : LexicalItem
	{
		public static readonly PpNewLine3 S = new PpNewLine3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SingleLineComment.S,
				NewLine.S);
		}
	}
}
