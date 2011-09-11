using Nuta.Parser.Lexical;

namespace NutaParser.Lexical.Grammar
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
