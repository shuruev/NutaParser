using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Tilde : ParseAll
	{
		public static readonly Tilde S = new Tilde();

		public Tilde()
			: base(
				Whitespace.O,
				TildeTerminal.S)
		{
		}
	}
}
