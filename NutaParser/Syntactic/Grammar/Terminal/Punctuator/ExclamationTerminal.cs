using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ExclamationTerminal : TextTerminal
	{
		public static readonly ExclamationTerminal S = new ExclamationTerminal();

		public ExclamationTerminal()
			: base("!")
		{
		}
	}
}
