using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class ApostropheTerminal : SingleCharacterTerminal
	{
		public static readonly ApostropheTerminal S = new ApostropheTerminal();

		public ApostropheTerminal()
			: base('\'')
		{
		}
	}
}
