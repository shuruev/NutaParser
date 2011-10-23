using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class AtKeyword : ParseAll
	{
		public static readonly AtKeyword S = new AtKeyword();

		public AtKeyword()
			: base(
				AtSignTerminal.S,
				Identifier.S)
		{
		}
	}
}
