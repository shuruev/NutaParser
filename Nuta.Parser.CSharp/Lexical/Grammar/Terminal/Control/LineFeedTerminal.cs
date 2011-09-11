using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class LineFeedTerminal : SingleCharacterTerminal
	{
		public static readonly LineFeedTerminal S = new LineFeedTerminal();

		public LineFeedTerminal()
			: base('\x000A')
		{
		}
	}
}
