namespace NutaParser.Lexical.Grammar
{
	public class PpDiagnostic4 : LexicalItem
	{
		public static readonly PpDiagnostic4 S = new PpDiagnostic4();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				ErrorTerminal.S,
				PpMessage.S);
		}
	}
}
