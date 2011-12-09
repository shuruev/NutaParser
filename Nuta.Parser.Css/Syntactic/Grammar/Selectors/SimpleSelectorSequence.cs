using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class SimpleSelectorSequence : ParseAny
	{
		public static readonly SimpleSelectorSequence S = new SimpleSelectorSequence();

		public SimpleSelectorSequence()
			: base(
				new ParseAll(
					new ParseAny(TypeSelector.S, Universal.S),
					SimpleSelectors.O),
				SimpleSelectors.S)
		{
		}
	}
}
