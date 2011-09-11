using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class IdentifierStartCharacter : ParseAny
	{
		public static readonly IdentifierStartCharacter S = new IdentifierStartCharacter();

		public IdentifierStartCharacter()
			: base(
				LetterCharacter.S,
				UnderscoreTerminal.S)
		{
		}
	}
}
