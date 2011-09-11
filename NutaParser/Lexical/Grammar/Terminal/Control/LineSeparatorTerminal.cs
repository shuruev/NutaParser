using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class LineSeparatorTerminal : SingleCharacterTerminal
	{
		public static readonly LineSeparatorTerminal S = new LineSeparatorTerminal();

		public LineSeparatorTerminal()
			: base('\x2028')
		{
		}
	}
}
