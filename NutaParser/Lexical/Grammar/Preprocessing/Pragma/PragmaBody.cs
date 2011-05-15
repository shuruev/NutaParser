namespace NutaParser.Lexical.Grammar
{
	public class PragmaBody : LexicalItem
	{
		public static readonly PragmaBody S = new PragmaBody();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PragmaWarningBody.S);
		}
	}
}
