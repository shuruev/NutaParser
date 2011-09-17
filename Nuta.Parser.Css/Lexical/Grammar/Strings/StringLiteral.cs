using Nuta.Parser.Lexical;

namespace Nuta.Parser.Css.Lexical
{
	public class StringLiteral : ParseAny
	{
		public static readonly StringLiteral S = new StringLiteral();

		public StringLiteral()
			: base(
				String1.S,
				String2.S)
		{
		}
	}
}
