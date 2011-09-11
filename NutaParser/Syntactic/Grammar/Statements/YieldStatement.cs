using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class YieldStatement : ParseAll
	{
		public static readonly YieldStatement S = new YieldStatement();

		public YieldStatement()
			: base(
				YieldTerminal.S,
				new ParseAny(
					new ParseAll(ReturnTerminal.S, Expression.S),
					BreakTerminal.S),
				SemicolonTerminal.S)
		{
		}
	}
}
