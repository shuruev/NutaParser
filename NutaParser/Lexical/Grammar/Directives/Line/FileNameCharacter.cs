namespace NutaParser.Lexical.Grammar
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
