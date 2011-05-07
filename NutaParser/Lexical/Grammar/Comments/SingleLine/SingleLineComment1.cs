namespace NutaParser.Lexical.Grammar
{
	public class SingleLineComment1 : LexicalItem
	{
		public static readonly SingleLineComment1 S = new SingleLineComment1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SlashTerminal.S,
				SlashTerminal.S,
				InputCharacters.S);
		}
	}
}
