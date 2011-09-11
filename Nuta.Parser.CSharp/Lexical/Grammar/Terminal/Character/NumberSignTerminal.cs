using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class NumberSignTerminal : SingleCharacterTerminal
	{
		public static readonly NumberSignTerminal S = new NumberSignTerminal();

		public NumberSignTerminal()
			: base('#')
		{
		}
	}
}
