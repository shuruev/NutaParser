using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Greater : ParseAll
	{
		public static readonly Greater S = new Greater();

		public Greater()
			: base(
				Whitespace.O,
				RightAngleBracketTerminal.S)
		{
		}
	}
}
