using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class NextLineTerminal : SingleCharacterTerminal
	{
		public static readonly NextLineTerminal S = new NextLineTerminal();

		public NextLineTerminal()
			: base('\x0085')
		{
		}
	}
}
