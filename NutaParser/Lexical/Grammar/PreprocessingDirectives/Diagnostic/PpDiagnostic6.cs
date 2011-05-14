namespace NutaParser.Lexical.Grammar
{
	public class PpDiagnostic6 : LexicalItem
	{
		public static readonly PpDiagnostic6 S = new PpDiagnostic6();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				WarningTerminal.S,
				PpMessage.S);
		}
	}
}
