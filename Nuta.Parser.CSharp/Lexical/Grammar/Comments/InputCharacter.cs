using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
