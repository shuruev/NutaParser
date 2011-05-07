namespace NutaParser.Lexical.Grammar
{
	public class SingleLineComment2 : LexicalItem
	{
		public static readonly SingleLineComment2 S = new SingleLineComment2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SlashTerminal.S,
				SlashTerminal.S);
		}
	}
}
