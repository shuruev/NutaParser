using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Plus : ParseAll
	{
		public static readonly Plus S = new Plus();

		public Plus()
			: base(
				Whitespace.O,
				PlusTerminal.S)
		{
		}
	}
}
