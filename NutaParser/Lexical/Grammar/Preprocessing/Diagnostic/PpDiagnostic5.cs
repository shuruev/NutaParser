namespace NutaParser.Lexical.Grammar
{
	public class PpDiagnostic5 : LexicalItem
	{
		public static readonly PpDiagnostic5 S = new PpDiagnostic5();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				Whitespace.S,
				WarningTerminal.S,
				PpMessage.S);
		}
	}
}
