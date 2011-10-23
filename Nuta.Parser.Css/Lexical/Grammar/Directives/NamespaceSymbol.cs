using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class NamespaceSymbol : ParseAll
	{
		public static readonly NamespaceSymbol S = new NamespaceSymbol();

		public NamespaceSymbol()
			: base(
				AtSignTerminal.S,
				LetterN.S,
				LetterA.S,
				LetterM.S,
				LetterE.S,
				LetterS.S,
				LetterP.S,
				LetterA.S,
				LetterC.S,
				LetterE.S)
		{
		}
	}
}
