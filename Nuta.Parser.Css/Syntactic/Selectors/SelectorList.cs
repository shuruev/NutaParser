using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class SelectorList : ParseMany
	{
		public static readonly SelectorList S = new SelectorList();

		public SelectorList()
			: base(
				new ParseAll(
					WhitespaceTerminal.O,
					Selector.S,
					WhitespaceTerminal.O),
				CommaTerminal.S)
		{
		}
	}
}
