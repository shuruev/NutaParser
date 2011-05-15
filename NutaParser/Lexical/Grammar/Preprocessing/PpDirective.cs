namespace NutaParser.Lexical.Grammar
{
	public class PpDirective : LexicalItem
	{
		public static readonly PpDirective S = new PpDirective();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				// TODO: PpDeclaration
				// TODO: PpConditional
				PpLine.S,
				// TODO: PpDiagnostic
				PpRegion.S,
				PpPragma.S);
		}
	}
}
