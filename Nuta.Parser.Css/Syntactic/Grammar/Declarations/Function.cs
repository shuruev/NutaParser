using Nuta.Parser.Css.Lexical;
using Nuta.Parser.Syntactic;

namespace Nuta.Parser.Css.Syntactic
{
	public class Function : SyntacticItem
	{
		public static readonly Function S = new Function();

		public override bool Parse(SyntacticState state)
		{
			return ParseAll(
				state,
				new LexicalTerminal(FunctionPrefix.S),
				Whitespaces.O,
				Expression.S,
				RightRoundBracketTerminal.S,
				Whitespaces.O);
		}
	}
}
