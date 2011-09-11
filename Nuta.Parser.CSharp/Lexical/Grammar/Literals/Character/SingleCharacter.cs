using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
