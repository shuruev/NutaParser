using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class HexColor : ParseAll
	{
		public static readonly HexColor S = new HexColor();

		public HexColor()
			: base(
				new LexicalTerminal(Hash.S),
				WhitespaceTerminal.O)
		{
		}
	}
}
