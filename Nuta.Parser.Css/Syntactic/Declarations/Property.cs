using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Property : ParseAll
	{
		public static readonly Property S = new Property();

		public Property()
			: base(
				new LexicalTerminal(Identifier.S),
				WhitespaceTerminal.O)
		{
		}
	}
}
