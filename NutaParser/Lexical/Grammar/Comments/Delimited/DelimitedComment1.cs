namespace NutaParser.Lexical.Grammar
{
	public class DelimitedComment1 : LexicalItem
	{
		public static readonly DelimitedComment1 S = new DelimitedComment1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SlashTerminal.S,
				AsteriskTerminal.S,
				DelimitedCommentText.S,
				Asterisks.S,
				SlashTerminal.S);
		}
	}
}
