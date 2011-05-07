namespace NutaParser.Lexical.Grammar
{
	public class PpMessage1 : LexicalItem
	{
		public static readonly PpMessage1 S = new PpMessage1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				InputCharacters.S,
				NewLine.S);
		}
	}
}
