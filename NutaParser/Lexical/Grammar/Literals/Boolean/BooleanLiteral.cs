namespace NutaParser.Lexical.Grammar
{
	public class BooleanLiteral : LexicalItem
	{
		public static readonly BooleanLiteral S = new BooleanLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseWord(
				state,
				"true",
				"false");
		}
	}
}
