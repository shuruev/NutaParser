namespace NutaParser.Lexical.Grammar
{
	public class Literal : LexicalItem
	{
		public static readonly Literal S = new Literal();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				StringLiteral.S,
				CharacterLiteral.S,
				RealLiteral.S,
				IntegerLiteral.S,
				BooleanLiteral.S,
				NullLiteral.S);
		}
	}
}
