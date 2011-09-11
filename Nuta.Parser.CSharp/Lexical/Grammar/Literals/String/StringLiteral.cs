using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
