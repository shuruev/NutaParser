using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class PpPrimaryExpression : LexicalItem
	{
		public static readonly PpPrimaryExpression S = new PpPrimaryExpression();

		public override bool Parse(LexicalState state)
		{
			return ParseAny(
				state,
				new ParseAll(
					LeftRoundBracketTerminal.S,
					Whitespace.O,
					PpExpression.S,
					Whitespace.O,
					RightRoundBracketTerminal.S),
				ConditionalSymbol.S,
				TrueTerminal.S,
				FalseTerminal.S);
		}
	}
}
