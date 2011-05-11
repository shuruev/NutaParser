namespace NutaParser.Lexical.Grammar
{
	public class PpDiagnostic2 : LexicalItem
	{
		public static readonly PpDiagnostic2 S = new PpDiagnostic2();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				SharpTerminal.S,
				ErrorTerminal.S,
				PpMessage.S);
		}
	}
}
