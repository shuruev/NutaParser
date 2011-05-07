namespace NutaParser.Lexical.Grammar
{
	public class PpPragma : LexicalItem
	{
		public static readonly PpPragma S = new PpPragma();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpPragma1.S,
				PpPragma2.S,
				PpPragma3.S,
				PpPragma4.S);
		}
	}
}
