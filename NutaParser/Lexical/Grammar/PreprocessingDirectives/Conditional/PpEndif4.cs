namespace NutaParser.Lexical.Grammar
{
	public class PpEndif4 : LexicalItem
	{
		public static readonly PpEndif4 S = new PpEndif4();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				NumberSignTerminal.S,
				EndifTerminal.S,
				PpNewLine.S);
		}
	}
}
