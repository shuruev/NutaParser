namespace NutaParser.Lexical.Grammar
{
	public class PragmaWarningBody : LexicalItem
	{
		public static readonly PragmaWarningBody S = new PragmaWarningBody();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				PragmaWarningBody1.S,
				PragmaWarningBody2.S);
		}
	}
}
