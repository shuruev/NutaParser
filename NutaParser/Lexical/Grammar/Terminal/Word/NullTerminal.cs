namespace NutaParser.Lexical.Grammar
{
	public class NullTerminal : LexicalItem
	{
		public static readonly NullTerminal S = new NullTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "null");
		}
	}
}
