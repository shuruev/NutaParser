using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class IdentifierOrKeyword : ParseAll
	{
		public static readonly IdentifierOrKeyword S = new IdentifierOrKeyword();

		public IdentifierOrKeyword()
			: base(IdentifierStartCharacter.S, IdentifierPartCharacters.O)
		{
		}
	}
}
