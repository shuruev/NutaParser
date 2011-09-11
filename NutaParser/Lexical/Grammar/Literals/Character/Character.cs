using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
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
