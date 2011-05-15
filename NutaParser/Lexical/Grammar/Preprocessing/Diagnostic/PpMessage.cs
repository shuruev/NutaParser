namespace NutaParser.Lexical.Grammar
{
	public class PpMessage : LexicalItem
	{
		public static readonly PpMessage S = new PpMessage();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PpMessage1.S,
				PpMessage2.S,
				NewLine.S);
		}
	}
}
