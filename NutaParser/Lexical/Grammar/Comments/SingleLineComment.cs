namespace NutaParser.Lexical.Grammar
{
	public class SingleLineComment : ParseAll
	{
		public static readonly SingleLineComment S = new SingleLineComment();
		public static readonly Optional O = new Optional(S);

		public SingleLineComment()
			: base(
				SlashTerminal.S,
				SlashTerminal.S,
				InputCharacters.O)
		{
		}
	}
}
