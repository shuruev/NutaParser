namespace NutaParser.Lexical.Grammar
{
	public class RegularStringLiteral : LexicalItem
	{
		public static readonly RegularStringLiteral S = new RegularStringLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				RegularStringLiteral1.S,
				RegularStringLiteral2.S);
		}
	}
}
