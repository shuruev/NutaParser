using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
