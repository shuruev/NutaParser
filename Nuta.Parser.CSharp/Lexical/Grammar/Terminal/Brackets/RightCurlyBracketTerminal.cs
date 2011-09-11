using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class RightCurlyBracketTerminal : SingleCharacterTerminal
	{
		public static readonly RightCurlyBracketTerminal S = new RightCurlyBracketTerminal();

		public RightCurlyBracketTerminal()
			: base('}')
		{
		}
	}
}
