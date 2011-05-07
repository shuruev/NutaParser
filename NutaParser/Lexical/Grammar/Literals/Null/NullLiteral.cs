namespace NutaParser.Lexical.Grammar
{
	public class NullLiteral : LexicalItem
	{
		public static readonly NullLiteral S = new NullLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(state, "null");
		}
	}
}
