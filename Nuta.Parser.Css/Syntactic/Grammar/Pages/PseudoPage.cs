using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class PseudoPage : ParseAll
	{
		public static readonly PseudoPage S = new PseudoPage();
		public static readonly Optional O = new Optional(S);

		public PseudoPage()
			: base(
				ColonTerminal.S,
				IdentifierTerminal.S)
		{
		}
	}
}
