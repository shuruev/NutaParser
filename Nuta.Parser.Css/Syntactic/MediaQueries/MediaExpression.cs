using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaExpression : ParseAll
	{
		public static readonly MediaExpression S = new MediaExpression();

		public MediaExpression()
			: base(
				LeftRoundBracketTerminal.S,
				Whitespaces.O,
				MediaFeature.S,
				Whitespaces.O,
				new Optional(
					new ParseAll(
						ColonTerminal.S,
						Whitespaces.O,
						Expression.S)),
				RightRoundBracketTerminal.S,
				Whitespaces.O)
		{
		}
	}
}
