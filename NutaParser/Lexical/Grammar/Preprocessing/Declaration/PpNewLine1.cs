namespace NutaParser.Lexical.Grammar
{
	public class PpNewLine1 : LexicalItem
	{
		public static readonly PpNewLine1 S = new PpNewLine1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				SingleLineComment.S,
				NewLine.S);
		}
	}
}
