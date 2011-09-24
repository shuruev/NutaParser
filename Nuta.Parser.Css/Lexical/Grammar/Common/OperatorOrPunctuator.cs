using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class OperatorOrPunctuator : ParseAny
	{
		public static readonly OperatorOrPunctuator S = new OperatorOrPunctuator();

		public OperatorOrPunctuator()
			: base(
				IncludesOperatorTerminal.S,
				DashmatchOperatorTerminal.S,
				RightAngleBracketTerminal.S,
				LeftCurlyBracketTerminal.S,
				RightCurlyBracketTerminal.S,
				LeftSquareBracketTerminal.S,
				RightSquareBracketTerminal.S,
				EqualTerminal.S,
				SemicolonTerminal.S,
				ColonTerminal.S,
				SlashTerminal.S,
				MinusTerminal.S,
				PlusTerminal.S,
				AsteriskTerminal.S,
				LeftRoundBracketTerminal.S,
				RightRoundBracketTerminal.S,
				CommaTerminal.S,
				PeriodTerminal.S)
		{
		}
	}
}
