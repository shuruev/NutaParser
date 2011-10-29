using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Combinator : ParseAny
	{
		public static readonly Combinator S = new Combinator();

		public Combinator()
			: base(
				new ParseAll(
					Whitespaces.O,
					new ParseAny(
						PlusTerminal.S,
						RightAngleBracketTerminal.S,
						TildeTerminal.S),
					Whitespaces.O),
				Whitespaces.S)
		{
		}
	}
}
