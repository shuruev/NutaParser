namespace NutaParser.Lexical.Grammar
{
	public class PpMessage : ParseAny
	{
		public static readonly PpMessage S = new PpMessage();

		public PpMessage()
			: base(
				new ParseAll(Whitespace.S, InputCharacters.O, NewLine.S),
				NewLine.S)
		{
		}
	}
}
