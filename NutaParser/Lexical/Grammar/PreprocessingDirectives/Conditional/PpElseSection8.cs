namespace NutaParser.Lexical.Grammar
{
	public class PpElseSection8 : LexicalItem
	{
		public static readonly PpElseSection8 S = new PpElseSection8();

		public override bool Parse(LexicalState state)
		{
			return ParseAll(
				state,
				SharpTerminal.S,
				ElseTerminal.S,
				PpNewLine.S);
		}
	}
}
