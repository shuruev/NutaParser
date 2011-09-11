using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class PeriodTerminal : SingleCharacterTerminal
	{
		public static readonly PeriodTerminal S = new PeriodTerminal();

		public PeriodTerminal()
			: base('.')
		{
		}
	}
}
