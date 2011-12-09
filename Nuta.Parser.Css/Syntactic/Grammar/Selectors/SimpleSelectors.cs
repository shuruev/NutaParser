using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class SimpleSelectors : ParseMany
	{
		public static readonly SimpleSelectors S = new SimpleSelectors();
		public static readonly Optional O = new Optional(S);

		public SimpleSelectors()
			: base(SimpleSelector.S)
		{
		}
	}
}
