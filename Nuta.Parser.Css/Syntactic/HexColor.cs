using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class HexColor : ParseAll
	{
		public static readonly HexColor S = new HexColor();

		public HexColor()
			: base(
				HashTerminal.S,
				WhitespaceTerminal.O)
		{
		}
	}
}
