using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class PpAndExpression : ParseMany
	{
		public static readonly PpAndExpression S = new PpAndExpression();

		public PpAndExpression()
			: base(
				PpEqualityExpression.S,
				new ParseAll(
					Whitespace.O,
					AndOperatorTerminal.S,
					Whitespace.O))
		{
		}
	}
}
