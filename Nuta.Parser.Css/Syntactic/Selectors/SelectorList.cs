using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class SelectorList : ParseMany
	{
		public static readonly SelectorList S = new SelectorList();

		public SelectorList()
			: base(
				new ParseAll(
					Whitespaces.O,
					Selector.S,
					Whitespaces.O),
				CommaTerminal.S)
		{
		}
	}
}
