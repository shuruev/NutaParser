using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
{
	public class Whitespace : ParseMany
	{
		public static readonly Whitespace S = new Whitespace();
		public static readonly Optional O = new Optional(S);

		public Whitespace()
			: base(WhitespaceCharacter.S)
		{
		}
	}
}
