namespace NutaParser.Lexical.Grammar
{
	public class PpDiagnostic8 : LexicalItem
	{
		public static readonly PpDiagnostic8 S = new PpDiagnostic8();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				SharpTerminal.S,
				WarningTerminal.S,
				PpMessage.S);
		}
	}
}
