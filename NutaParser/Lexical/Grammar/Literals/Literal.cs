using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class Literal : ParseAny
	{
		public static readonly Literal S = new Literal();

		public Literal()
			: base(
				StringLiteral.S,
				CharacterLiteral.S,
				RealLiteral.S,
				IntegerLiteral.S,
				BooleanLiteral.S,
				NullLiteral.S)
		{
		}
	}
}
