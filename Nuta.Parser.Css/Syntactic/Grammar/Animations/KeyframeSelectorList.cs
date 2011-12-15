using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class KeyframeSelectorList : ParseMany
	{
		public static readonly KeyframeSelectorList S = new KeyframeSelectorList();

		public KeyframeSelectorList()
			: base(
				new ParseAll(
					Whitespaces.O,
					KeyframeSelector.S,
					Whitespaces.O),
				CommaTerminal.S)
		{
		}
	}
}
