using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class ExclamationTerminal : SingleCharacterTerminal
	{
		public static readonly ExclamationTerminal S = new ExclamationTerminal();

		public ExclamationTerminal()
			: base('!')
		{
		}
	}
}
