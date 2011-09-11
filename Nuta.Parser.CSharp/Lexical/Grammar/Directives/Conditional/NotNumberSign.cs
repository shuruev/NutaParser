using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class NotNumberSign : ParseExcept
	{
		public static readonly NotNumberSign S = new NotNumberSign();

		public NotNumberSign()
			: base(InputCharacter.S, NumberSignTerminal.S)
		{
		}
	}
}
