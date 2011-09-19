using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class Hash : ParseAll
	{
		public static readonly Hash S = new Hash();

		public Hash()
			: base(
				AsteriskTerminal.S,
				Name.S)
		{
		}
	}
}
