namespace NutaParser.Lexical.Grammar
{
	public class ElifTerminal : LexicalItem
	{
		public static readonly ElifTerminal S = new ElifTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "elif");
		}
	}
}
