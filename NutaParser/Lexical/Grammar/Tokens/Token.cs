namespace NutaParser.Lexical.Grammar
{
	public class Token : LexicalItem
	{
		public static readonly Token S = new Token();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				Identifier.S,
				Keyword.S,
				StringLiteral.S,
				CharacterLiteral.S,
				RealLiteral.S,
				IntegerLiteral.S,
				OperatorOrPunctuator.S);
		}
	}
}
