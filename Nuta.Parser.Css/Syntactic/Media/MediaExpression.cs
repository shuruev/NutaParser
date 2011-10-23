using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class MediaExpression : ParseAll
	{
		public static readonly MediaExpression S = new MediaExpression();

		public MediaExpression()
			: base(
				LeftRoundBracketTerminal.S,
				WhitespaceTerminal.O,
				MediaFeature.S,
				WhitespaceTerminal.O,
				new Optional(
					new ParseAll(
						ColonTerminal.S,
						WhitespaceTerminal.O,
						Expression.S)),
				RightRoundBracketTerminal.S,
				WhitespaceTerminal.O)
		{
		}
	}
}
