namespace NutaParser.Lexical.Grammar
{
	public class VerbatimStringLiteral : LexicalItem
	{
		public static readonly VerbatimStringLiteral S = new VerbatimStringLiteral();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				VerbatimStringLiteral1.S,
				VerbatimStringLiteral2.S);
		}
	}
}
