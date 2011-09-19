using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class ImportantSymbol : ParseAll
	{
		public static readonly ImportantSymbol S = new ImportantSymbol();

		public ImportantSymbol()
			: base(
				ExclamationTerminal.S,
				ImportantDelimiter.O,
				LetterI.S,
				LetterM.S,
				LetterP.S,
				LetterO.S,
				LetterR.S,
				LetterT.S,
				LetterA.S,
				LetterN.S,
				LetterT.S)
		{
		}
	}
}
