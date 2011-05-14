namespace NutaParser.Lexical.Grammar
{
	public class InputCharacter : ParseExcept
	{
		public static readonly InputCharacter S = new InputCharacter();

		public InputCharacter()
			: base(AnyCharacterTerminal.S, NewLineCharacter.S)
		{
		}
	}
}
