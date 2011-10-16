using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Comma : ParseAll
	{
		public static readonly Comma S = new Comma();

		public Comma()
			: base(
				Whitespace.O,
				CommaTerminal.S)
		{
		}
	}
}
