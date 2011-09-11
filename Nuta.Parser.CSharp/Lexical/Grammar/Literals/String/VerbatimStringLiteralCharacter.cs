using Nuta.Parser.Lexical;

namespace Nuta.Parser.CSharp.Lexical
{
	public class VerbatimStringLiteralCharacter : ParseAny
	{
		public static readonly VerbatimStringLiteralCharacter S = new VerbatimStringLiteralCharacter();

		public VerbatimStringLiteralCharacter()
			: base(
				SingleVerbatimStringLiteralCharacter.S,
				QuoteEscapeSequence.S)
		{
		}
	}
}
