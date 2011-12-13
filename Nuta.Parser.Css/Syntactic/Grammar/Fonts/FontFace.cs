using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class FontFace : ParseAll
	{
		public static readonly FontFace S = new FontFace();

		public FontFace()
			: base(
				new LexicalTerminal(FontFaceSymbol.S),
				Whitespaces.O,
				LeftCurlyBracketTerminal.S,
				DeclarationList.S,
				RightCurlyBracketTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
