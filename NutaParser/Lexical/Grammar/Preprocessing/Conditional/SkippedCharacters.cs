namespace NutaParser.Lexical.Grammar
{
	public class SkippedCharacters : ParseAll
	{
		public static readonly SkippedCharacters S = new SkippedCharacters();
		public static readonly Optional O = new Optional(S);

		public SkippedCharacters()
			: base(
				Whitespace.O,
				NotNumberSign.S,
				InputCharacters.O)
		{
		}
	}
}
