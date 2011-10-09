using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class SimpleSelector : ParseAny
	{
		public static readonly SimpleSelector S = new SimpleSelector();

		public SimpleSelector()
			: base(
				new ParseMany(SimpleSelectorPart.S),
				new ParseAll(ElementName.S, new ParseMany(SimpleSelectorPart.S)),
				ElementName.S)
		{
		}
	}
}
