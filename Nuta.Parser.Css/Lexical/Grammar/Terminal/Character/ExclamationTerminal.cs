using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
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
