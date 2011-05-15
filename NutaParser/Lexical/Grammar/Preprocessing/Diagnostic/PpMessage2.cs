namespace NutaParser.Lexical.Grammar
{
	public class PpMessage2 : LexicalItem
	{
		public static readonly PpMessage2 S = new PpMessage2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NewLine.S);
		}
	}
}
