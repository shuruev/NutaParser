namespace NutaParser.Lexical.Grammar
{
	public class NewLineCharacter : ParseAny
	{
		public static readonly NewLineCharacter S = new NewLineCharacter();

		public NewLineCharacter()
			: base(
				CarriageReturnTerminal.S,
				LineFeedTerminal.S,
				NextLineTerminal.S,
				LineSeparatorTerminal.S,
				ParagraphSeparatorTerminal.S)
		{
		}
	}
}
