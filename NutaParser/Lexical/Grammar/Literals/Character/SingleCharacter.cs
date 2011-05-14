namespace NutaParser.Lexical.Grammar
{
	public class SingleCharacter : ParseExcept
	{
		public static readonly SingleCharacter S = new SingleCharacter();

		public SingleCharacter()
			: base(
				AnyCharacterTerminal.S,
				new ParseAny(ApostropheTerminal.S, BackslashTerminal.S, NewLineCharacter.S))
		{
		}
	}
}
