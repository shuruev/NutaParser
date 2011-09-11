using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class PpExpression : ParseAll
	{
		public static readonly PpExpression S = new PpExpression();

		public PpExpression()
			: base(
				Whitespace.O,
				PpOrExpression.S,
				Whitespace.O)
		{
		}
	}
}
