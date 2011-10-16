using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Selector : ParseAll
	{
		public static readonly Selector S = new Selector();

		public Selector()
			: base(
				new ParseMany(
					SimpleSelector.S,
					new ParseAny(
						new ParseAll(WhitespaceTerminal.S, Combinator.S),
						WhitespaceTerminal.S,
						Combinator.S)),
				WhitespaceTerminal.O)
		{
		}
	}
}
