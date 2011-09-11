using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class PpOrExpression : ParseMany
	{
		public static readonly PpOrExpression S = new PpOrExpression();

		public PpOrExpression()
			: base(
				PpAndExpression.S,
				new ParseAll(
					Whitespace.O,
					OrOperatorTerminal.S,
					Whitespace.O))
		{
		}
	}
}
