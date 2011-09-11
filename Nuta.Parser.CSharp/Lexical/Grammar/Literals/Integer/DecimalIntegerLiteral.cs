using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical.Grammar
{
	public class DecimalIntegerLiteral : ParseAll
	{
		public static readonly DecimalIntegerLiteral S = new DecimalIntegerLiteral();

		public DecimalIntegerLiteral()
			: base(DecimalDigits.S, IntegerTypeSuffix.O)
		{
		}
	}
}
