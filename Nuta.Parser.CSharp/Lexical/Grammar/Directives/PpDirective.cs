using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class PpDirective : LexicalItem
	{
		public static readonly PpDirective S = new PpDirective();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpDeclaration.S,
				PpConditional.S,
				PpLine.S,
				PpDiagnostic.S,
				PpRegion.S,
				PpPragma.S);
		}
	}
}
