namespace NutaParser.Lexical.Grammar
{
	public class PragmaTerminal : LexicalItem
	{
		public static readonly PragmaTerminal S = new PragmaTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "pragma");
		}
	}
}
