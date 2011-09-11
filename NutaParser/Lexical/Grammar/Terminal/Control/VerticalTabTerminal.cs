using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class VerticalTabTerminal : SingleCharacterTerminal
	{
		public static readonly VerticalTabTerminal S = new VerticalTabTerminal();

		public VerticalTabTerminal()
			: base('\x000B')
		{
		}
	}
}
