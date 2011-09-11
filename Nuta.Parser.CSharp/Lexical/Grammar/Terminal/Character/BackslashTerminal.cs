using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class BackslashTerminal : SingleCharacterTerminal
	{
		public static readonly BackslashTerminal S = new BackslashTerminal();

		public BackslashTerminal()
			: base('\\')
		{
		}
	}
}
