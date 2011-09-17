using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class HyphenTerminal : SingleCharacterTerminal
	{
		public static readonly HyphenTerminal S = new HyphenTerminal();
		public static readonly Optional O = new Optional(S);

		public HyphenTerminal()
			: base('-')
		{
		}
	}
}
