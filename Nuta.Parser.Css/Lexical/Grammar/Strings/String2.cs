using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class String2 : ParseAll
	{
		public static readonly String2 S = new String2();

		public String2()
			: base(
				ApostropheTerminal.S,
				String2Characters.O,
				ApostropheTerminal.S)
		{
		}
	}
}
