using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class Sign : SingleCharacterTerminal
	{
		public static readonly Sign S = new Sign();
		public static readonly Optional O = new Optional(S);

		public Sign()
			: base('+', '-')
		{
		}
	}
}
