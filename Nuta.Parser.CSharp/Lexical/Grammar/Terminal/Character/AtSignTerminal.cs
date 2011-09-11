using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class AtSignTerminal : SingleCharacterTerminal
	{
		public static readonly AtSignTerminal S = new AtSignTerminal();

		public AtSignTerminal()
			: base('@')
		{
		}
	}
}
