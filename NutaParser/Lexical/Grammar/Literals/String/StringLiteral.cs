namespace NutaParser.Lexical.Grammar
{
	public class StringLiteral : LexicalItem
	{
		public static readonly StringLiteral S = new StringLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				VerbatimStringLiteral.S,
				RegularStringLiteral.S);
		}
	}
}
