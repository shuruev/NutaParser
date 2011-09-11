using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class Character : ParseAny
	{
		public static readonly Character S = new Character();

		public Character()
			: base(
				UnicodeEscapeSequence.S,
				HexadecimalEscapeSequence.S,
				SimpleEscapeSequence.S,
				SingleCharacter.S)
		{
		}
	}
}
