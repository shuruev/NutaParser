using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class StringLiteral : ParseAny
	{
		public static readonly StringLiteral S = new StringLiteral();

		public StringLiteral()
			: base(
				VerbatimStringLiteral.S,
				RegularStringLiteral.S)
		{
		}
	}
}
