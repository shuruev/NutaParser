using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NonAscii : LexicalItem
	{
		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, c => c >= 160);
		}
	}
}
