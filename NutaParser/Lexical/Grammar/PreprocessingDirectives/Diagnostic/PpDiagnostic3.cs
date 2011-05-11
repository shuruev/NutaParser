namespace NutaParser.Lexical.Grammar
{
	public class PpDiagnostic3 : LexicalItem
	{
		public static readonly PpDiagnostic3 S = new PpDiagnostic3();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SharpTerminal.S,
				Whitespace.S,
				ErrorTerminal.S,
				PpMessage.S);
		}
	}
}
