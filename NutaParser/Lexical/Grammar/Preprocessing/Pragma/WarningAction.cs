namespace NutaParser.Lexical.Grammar
{
	public class WarningAction : LexicalItem
	{
		public static readonly WarningAction S = new WarningAction();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "disable", "restore");
		}
	}
}
