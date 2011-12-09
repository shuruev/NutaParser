using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Selector : ParseMany
	{
		public static readonly Selector S = new Selector();

		public Selector()
			: base(
				SimpleSelectorSequence.S,
				Combinator.S)
		{
		}
	}
}
