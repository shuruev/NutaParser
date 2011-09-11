using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class HyphenTerminal : SingleCharacterTerminal
	{
		public static readonly HyphenTerminal S = new HyphenTerminal();

		public HyphenTerminal()
			: base('-')
		{
		}
	}
}
