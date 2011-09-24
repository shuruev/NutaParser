using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class MinusTerminal : SingleCharacterTerminal
	{
		public static readonly MinusTerminal S = new MinusTerminal();

		public MinusTerminal()
			: base('-')
		{
		}
	}
}
