using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class NegationArgument : ParseAny
	{
		public static readonly NegationArgument S = new NegationArgument();

		public NegationArgument()
			: base(
				TypeSelector.S,
				Universal.S,
				new LexicalTerminal(Hash.S),
				Class.S,
				Attribute.S,
				Pseudo.S)
		{
		}
	}
}
