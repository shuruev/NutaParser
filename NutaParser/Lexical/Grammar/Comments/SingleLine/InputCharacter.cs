namespace NutaParser.Lexical.Grammar
{
	public class InputCharacter : LexicalItem
	{
		public static readonly InputCharacter S = new InputCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, c => !NewLineCharacter.Check(c));
		}
	}
}
