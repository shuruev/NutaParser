using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
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
