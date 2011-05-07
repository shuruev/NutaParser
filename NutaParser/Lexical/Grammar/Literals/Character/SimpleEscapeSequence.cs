namespace NutaParser.Lexical.Grammar
{
	public class SimpleEscapeSequence : LexicalItem
	{
		public static readonly SimpleEscapeSequence S = new SimpleEscapeSequence();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(
				state,
				@"\'",
				"\\\"",
				@"\\",
				@"\0",
				@"\a",
				@"\b",
				@"\f",
				@"\n",
				@"\r",
				@"\t",
				@"\v");
		}
	}
}
