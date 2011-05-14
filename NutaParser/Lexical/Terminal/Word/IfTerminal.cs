namespace NutaParser.Lexical.Grammar
{
	public class IfTerminal : LexicalItem
	{
		public static readonly IfTerminal S = new IfTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "if");
		}
	}
}
