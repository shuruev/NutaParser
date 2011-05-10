namespace NutaParser.Lexical.Grammar
{
	public class FileName : LexicalItem
	{
		public static readonly FileName S = new FileName();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				QuoteTerminal.S,
				FileNameCharacters.S,
				QuoteTerminal.S);
		}
	}
}
