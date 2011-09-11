using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class PpUnaryExpression : ParseAll
	{
		public static readonly PpUnaryExpression S = new PpUnaryExpression();

		public PpUnaryExpression()
			: base(
				new Optional(
					new ParseMany(
						new ParseAll(ExclamationTerminal.S, Whitespace.O))),
				PpPrimaryExpression.S)
		{
		}
	}
}
