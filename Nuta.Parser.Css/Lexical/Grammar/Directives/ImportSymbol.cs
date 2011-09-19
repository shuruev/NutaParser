using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class ImportSymbol : ParseAll
	{
		public static readonly ImportSymbol S = new ImportSymbol();

		public ImportSymbol()
			: base(
				AtSignTerminal.S,
				LetterI.S,
				LetterM.S,
				LetterP.S,
				LetterO.S,
				LetterR.S,
				LetterT.S)
		{
		}
	}
}
