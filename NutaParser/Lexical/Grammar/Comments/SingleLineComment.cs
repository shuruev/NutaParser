namespace NutaParser.Lexical.Grammar
{
	public class SingleLineComment : ParseAll
	{
		public static readonly SingleLineComment S = new SingleLineComment();

		public SingleLineComment()
			: base(
				SlashTerminal.S,
				SlashTerminal.S,
				InputCharacters.O)
		{
		}
	}
}
