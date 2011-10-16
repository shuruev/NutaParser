using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Combinator : ParseAll
	{
		public static readonly Combinator S = new Combinator();

		public Combinator()
			: base(
				new ParseAny(
					PlusTerminal.S,
					RightAngleBracketTerminal.S,
					TildeTerminal.S),
				WhitespaceTerminal.O)
		{
		}
	}
}
