using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class LeftCurlyBracketTerminal : SingleCharacterTerminal
	{
		public static readonly LeftCurlyBracketTerminal S = new LeftCurlyBracketTerminal();

		public LeftCurlyBracketTerminal()
			: base('{')
		{
		}
	}
}
