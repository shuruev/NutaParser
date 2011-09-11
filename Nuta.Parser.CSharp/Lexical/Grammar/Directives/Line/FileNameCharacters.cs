using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class FileNameCharacters : ParseMany
	{
		public static readonly FileNameCharacters S = new FileNameCharacters();

		public FileNameCharacters()
			: base(FileNameCharacter.S)
		{
		}
	}
}
