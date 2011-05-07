namespace NutaParser.Lexical.Grammar
{
	public class CombiningCharacter : LexicalItem
	{
		public static readonly CombiningCharacter S = new CombiningCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				CombiningCharacter1.S,
				CombiningCharacter2.S);
		}
	}
}
