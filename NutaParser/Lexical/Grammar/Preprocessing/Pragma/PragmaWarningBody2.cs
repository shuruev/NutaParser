namespace NutaParser.Lexical.Grammar
{
	public class PragmaWarningBody2 : LexicalItem
	{
		public static readonly PragmaWarningBody2 S = new PragmaWarningBody2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				WarningTerminal.S,
				Whitespace.S,
				WarningAction.S);
		}
	}
}
