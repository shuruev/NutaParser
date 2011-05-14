namespace NutaParser.Lexical.Grammar
{
	public class PpDiagnostic1 : LexicalItem
	{
		public static readonly PpDiagnostic1 S = new PpDiagnostic1();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				Whitespace.S,
				NumberSignTerminal.S,
				Whitespace.S,
				ErrorTerminal.S,
				PpMessage.S);
		}
	}
}
