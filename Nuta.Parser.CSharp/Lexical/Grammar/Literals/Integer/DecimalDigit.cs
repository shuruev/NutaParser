using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class DecimalDigit : SingleCharacterTerminal
	{
		public static readonly DecimalDigit S = new DecimalDigit();

		public DecimalDigit()
			: base('0', '1', '2', '3', '4', '5', '6', '7', '8', '9')
		{
		}
	}
}
