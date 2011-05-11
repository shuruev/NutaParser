namespace NutaParser.Lexical.Grammar
{
	public class PpDiagnostic7 : LexicalItem
	{
		public static readonly PpDiagnostic7 S = new PpDiagnostic7();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SharpTerminal.S,
				Whitespace.S,
				WarningTerminal.S,
				PpMessage.S);
		}
	}
}
