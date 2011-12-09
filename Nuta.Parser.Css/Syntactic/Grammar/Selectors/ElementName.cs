using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class ElementName : ParseAll
	{
		public static readonly ElementName S = new ElementName();

		public ElementName()
			: base(new LexicalTerminal(Identifier.S))
		{
		}
	}
}
