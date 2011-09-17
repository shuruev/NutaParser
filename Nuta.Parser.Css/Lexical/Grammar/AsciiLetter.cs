using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class AsciiLetter : LexicalItem
	{
		public static readonly AsciiLetter S = new AsciiLetter();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(
				state,
				c =>
					(c >= 'a' && c <= 'z')
					|| (c >= 'A' && c <= 'Z'));
		}
	}
}
