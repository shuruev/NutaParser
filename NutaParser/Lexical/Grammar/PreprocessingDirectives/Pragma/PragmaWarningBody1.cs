namespace NutaParser.Lexical.Grammar
{
	public class PragmaWarningBody1 : LexicalItem
	{
		public static readonly PragmaWarningBody1 S = new PragmaWarningBody1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				WarningTerminal.S,
				Whitespace.S,
				WarningAction.S,
				Whitespace.S,
				WarningList.S);
		}
	}
}
