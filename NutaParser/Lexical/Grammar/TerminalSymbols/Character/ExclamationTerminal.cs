namespace NutaParser.Lexical.Grammar
{
	public class ExclamationTerminal : LexicalItem
	{
		public static readonly ExclamationTerminal S = new ExclamationTerminal();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, '!');
		}
	}
}
