using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class SimpleSelectorPart : ParseAny
	{
		public static readonly SimpleSelectorPart S = new SimpleSelectorPart();

		public SimpleSelectorPart()
			: base(
				new LexicalTerminal(Hash.S),
				Class.S,
				Attribute.S,
				PseudoClass.S)
		{
		}
	}
}
