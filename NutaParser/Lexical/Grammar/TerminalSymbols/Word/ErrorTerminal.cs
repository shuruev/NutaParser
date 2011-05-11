namespace NutaParser.Lexical.Grammar
{
	public class ErrorTerminal : LexicalItem
	{
		public static readonly ErrorTerminal S = new ErrorTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "error");
		}
	}
}
