using Nuta.Parser.Syntactic;

namespace NutaParser.Syntactic.Grammar
{
	public class ForIterator : ParseAll
	{
		public static readonly ForIterator S = new ForIterator();
		public static readonly Optional O = new Optional(S);

		public ForIterator()
			: base(StatementExpressionList.S)
		{
		}
	}
}
