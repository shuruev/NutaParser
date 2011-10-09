using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Attribute : ParseAll
	{
		public static readonly Attribute S = new Attribute();

		public Attribute()
			: base(
				LeftSquareBracketTerminal.S,
				WhitespaceTerminal.O,
				new LexicalTerminal(Identifier.S),
				WhitespaceTerminal.O,
				AttributePart.O,
				RightSquareBracketTerminal.S)
		{
		}
	}
}
