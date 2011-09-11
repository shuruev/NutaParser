using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class ParagraphSeparatorTerminal : SingleCharacterTerminal
	{
		public static readonly ParagraphSeparatorTerminal S = new ParagraphSeparatorTerminal();

		public ParagraphSeparatorTerminal()
			: base('\x2029')
		{
		}
	}
}
