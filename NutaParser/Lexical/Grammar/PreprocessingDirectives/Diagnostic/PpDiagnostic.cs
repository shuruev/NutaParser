namespace NutaParser.Lexical.Grammar
{
	public class PpDiagnostic : LexicalItem
	{
		public static readonly PpDiagnostic S = new PpDiagnostic();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpDiagnostic1.S,
				PpDiagnostic2.S,
				PpDiagnostic3.S,
				PpDiagnostic4.S,
				PpDiagnostic5.S,
				PpDiagnostic6.S,
				PpDiagnostic7.S,
				PpDiagnostic8.S);
		}
	}
}
