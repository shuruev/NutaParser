namespace NutaParser.Lexical.Grammar
{
	public class DelimitedComment2 : LexicalItem
	{
		public static readonly DelimitedComment2 S = new DelimitedComment2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SlashTerminal.S,
				AsteriskTerminal.S,
				Asterisks.S,
				SlashTerminal.S);
		}
	}
}
