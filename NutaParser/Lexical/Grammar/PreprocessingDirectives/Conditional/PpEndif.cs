namespace NutaParser.Lexical.Grammar
{
	public class PpEndif : LexicalItem
	{
		public static readonly PpEndif S = new PpEndif();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpEndif1.S,
				PpEndif2.S,
				PpEndif3.S,
				PpEndif4.S);
		}
	}
}
