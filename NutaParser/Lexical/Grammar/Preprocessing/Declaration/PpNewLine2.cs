namespace NutaParser.Lexical.Grammar
{
	public class PpNewLine2 : LexicalItem
	{
		public static readonly PpNewLine2 S = new PpNewLine2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NewLine.S);
		}
	}
}
