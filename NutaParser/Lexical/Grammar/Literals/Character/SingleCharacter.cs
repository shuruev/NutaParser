namespace NutaParser.Lexical.Grammar
{
	public class SingleCharacter : LexicalItem
	{
		public static readonly SingleCharacter S = new SingleCharacter();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c => c != '\''
					&& c != '\\'
					&& !NewLineCharacter.Check(c));
		}
	}
}
