using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class HexDigit : SingleCharacterTerminal
	{
		public static readonly HexDigit S = new HexDigit();
		public static readonly Optional O = new Optional(S);

		public HexDigit()
			: base('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'a', 'b', 'c', 'd', 'e', 'f')
		{
		}
	}
}
