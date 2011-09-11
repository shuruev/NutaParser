using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class FileNameCharacter : ParseExcept
	{
		public static readonly FileNameCharacter S = new FileNameCharacter();

		public FileNameCharacter()
			: base(InputCharacter.S, QuoteTerminal.S)
		{
		}
	}
}
