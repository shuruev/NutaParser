using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
