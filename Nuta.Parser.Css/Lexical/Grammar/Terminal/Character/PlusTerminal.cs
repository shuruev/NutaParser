using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class PlusTerminal : SingleCharacterTerminal
	{
		public static readonly PlusTerminal S = new PlusTerminal();

		public PlusTerminal()
			: base('+')
		{
		}
	}
}
