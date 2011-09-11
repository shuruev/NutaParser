using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class CommaTerminal : SingleCharacterTerminal
	{
		public static readonly CommaTerminal S = new CommaTerminal();

		public CommaTerminal()
			: base(',')
		{
		}
	}
}
