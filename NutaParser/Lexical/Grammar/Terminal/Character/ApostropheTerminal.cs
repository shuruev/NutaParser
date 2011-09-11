using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
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
