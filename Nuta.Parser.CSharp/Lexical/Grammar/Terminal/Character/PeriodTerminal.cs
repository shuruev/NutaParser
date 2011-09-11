using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
