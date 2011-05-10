namespace NutaParser.Lexical.Grammar
{
	public class DefaultTerminal : LexicalItem
	{
		public static readonly DefaultTerminal S = new DefaultTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "default");
		}
	}
}
