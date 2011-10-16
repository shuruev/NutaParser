using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NonAscii : LexicalItem
	{
		public static readonly NonAscii S = new NonAscii();

		public override bool Parse(LexicalState state)
		{
			return ParseCharacter(state, c => c > 177);
		}
	}
}
