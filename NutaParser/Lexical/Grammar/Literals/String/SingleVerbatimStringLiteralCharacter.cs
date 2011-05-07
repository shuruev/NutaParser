namespace NutaParser.Lexical.Grammar
{
	public class SingleVerbatimStringLiteralCharacter : LexicalItem
	{
		public static readonly SingleVerbatimStringLiteralCharacter S = new SingleVerbatimStringLiteralCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, c => c != '"');
		}
	}
}
