namespace NutaParser.Lexical.Grammar
{
	public class SingleRegularStringLiteralCharacter : LexicalItem
	{
		public static readonly SingleRegularStringLiteralCharacter S = new SingleRegularStringLiteralCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => c != '"'
					&& c != '\\'
					&& !NewLineCharacter.Check(c));
		}
	}
}
