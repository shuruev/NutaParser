using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class UnderscoreTerminal : SingleCharacterTerminal
	{
		public static readonly UnderscoreTerminal S = new UnderscoreTerminal();

		public UnderscoreTerminal()
			: base('_')
		{
		}
	}
}
